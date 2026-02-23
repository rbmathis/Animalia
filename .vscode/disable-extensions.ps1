<#
.SYNOPSIS
    Disables extensions listed in extensions.json for this workspace.

.DESCRIPTION
    Reads the unwantedRecommendations from .vscode/extensions.json and disables
    those extensions. By default, disables for the current workspace only by
    updating the VS Code workspace storage database.

.PARAMETER Global
    Disable extensions globally instead of just for this workspace.

.EXAMPLE
    .\disable-extensions.ps1
    Disables extensions for this workspace only.

.EXAMPLE
    .\disable-extensions.ps1 -Global
    Disables extensions globally using VS Code CLI.
#>

param(
    [switch]$Global
)

$ErrorActionPreference = "Stop"
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$extensionsJsonPath = Join-Path $scriptDir "extensions.json"

if (-not (Test-Path $extensionsJsonPath)) {
    Write-Error "extensions.json not found at: $extensionsJsonPath"
    exit 1
}

$extensionsJson = Get-Content $extensionsJsonPath -Raw | ConvertFrom-Json
$unwantedExtensions = $extensionsJson.unwantedRecommendations

if (-not $unwantedExtensions -or $unwantedExtensions.Count -eq 0) {
    Write-Host "No extensions listed in unwantedRecommendations." -ForegroundColor Yellow
    exit 0
}

Write-Host "Found $($unwantedExtensions.Count) extensions to disable:" -ForegroundColor Cyan
$unwantedExtensions | ForEach-Object { Write-Host "  - $_" -ForegroundColor Gray }
Write-Host ""

if ($Global) {
    Write-Host "Disabling extensions globally via VS Code CLI..." -ForegroundColor Yellow
    foreach ($ext in $unwantedExtensions) {
        Write-Host "  Disabling: $ext" -ForegroundColor Gray
        code --disable-extension $ext 2>$null
    }
    Write-Host "`nDone! Restart VS Code for changes to take effect." -ForegroundColor Green
}
else {
    # Find the workspace storage folder for this workspace
    $workspaceFolder = (Get-Item $scriptDir).Parent.FullName
    $workspaceFolderUri = "file:///" + ($workspaceFolder -replace "\\", "/" -replace ":", "%3A")

    $workspaceStorageRoot = Join-Path $env:APPDATA "Code\User\workspaceStorage"
    $targetStorageFolder = $null

    Get-ChildItem $workspaceStorageRoot -Directory | ForEach-Object {
        $wsJsonPath = Join-Path $_.FullName "workspace.json"
        if (Test-Path $wsJsonPath) {
            $wsJson = Get-Content $wsJsonPath -Raw | ConvertFrom-Json
            $folderUri = $wsJson.folder
            if ($folderUri -and $workspaceFolder -and $folderUri -match [regex]::Escape(($workspaceFolder -replace "\\", "/" -replace ":", "%3A"))) {
                $targetStorageFolder = $_.FullName
            }
        }
    }

    if (-not $targetStorageFolder) {
        Write-Host "Could not find workspace storage folder. Open this workspace in VS Code first." -ForegroundColor Red
        Write-Host "Alternatively, use -Global to disable extensions globally." -ForegroundColor Yellow
        exit 1
    }

    $dbPath = Join-Path $targetStorageFolder "state.vscdb"
    if (-not (Test-Path $dbPath)) {
        Write-Error "VS Code state database not found at: $dbPath"
        exit 1
    }

    Write-Host "Workspace storage found: $targetStorageFolder" -ForegroundColor Green
    Write-Host "Updating disabled extensions in workspace..." -ForegroundColor Yellow

    # Build the JSON array for disabled extensions
    $disabledArray = $unwantedExtensions | ForEach-Object {
        @{ id = $_ }
    }
    $disabledJson = $disabledArray | ConvertTo-Json -Compress
    if ($unwantedExtensions.Count -eq 1) {
        $disabledJson = "[$disabledJson]"
    }

    # Use Python to update SQLite (more reliable than other methods on Windows)
    $pythonScript = @"
import sqlite3
import sys

db_path = sys.argv[1]
disabled_json = sys.argv[2]

conn = sqlite3.connect(db_path)
cursor = conn.cursor()

# Check if key exists
cursor.execute("SELECT COUNT(*) FROM ItemTable WHERE key = 'extensionsIdentifiers/disabled'")
exists = cursor.fetchone()[0] > 0

if exists:
    cursor.execute("UPDATE ItemTable SET value = ? WHERE key = 'extensionsIdentifiers/disabled'", (disabled_json,))
else:
    cursor.execute("INSERT INTO ItemTable (key, value) VALUES ('extensionsIdentifiers/disabled', ?)", (disabled_json,))

conn.commit()
conn.close()
print("Database updated successfully")
"@

    $tempPyScript = Join-Path $env:TEMP "update_vscode_extensions.py"
    $pythonScript | Out-File -FilePath $tempPyScript -Encoding UTF8

    try {
        # Close VS Code's connection by copying the database
        $tempDb = Join-Path $env:TEMP "state_temp.vscdb"
        Copy-Item $dbPath $tempDb -Force

        python $tempPyScript $tempDb $disabledJson

        # Copy back (VS Code should be closed or will reload state)
        Copy-Item $tempDb $dbPath -Force

        Remove-Item $tempDb -ErrorAction SilentlyContinue
        Remove-Item $tempPyScript -ErrorAction SilentlyContinue

        Write-Host "`nSuccessfully disabled $($unwantedExtensions.Count) extensions for this workspace!" -ForegroundColor Green
        Write-Host "Restart VS Code (or reload window) for changes to take effect." -ForegroundColor Cyan
    }
    catch {
        Write-Host "Error updating database: $_" -ForegroundColor Red
        Write-Host "Make sure VS Code is closed and Python is installed." -ForegroundColor Yellow
        Write-Host "Alternatively, use -Global to disable extensions globally." -ForegroundColor Yellow
        Remove-Item $tempPyScript -ErrorAction SilentlyContinue
        exit 1
    }
}
