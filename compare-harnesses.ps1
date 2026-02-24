#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Side-by-side comparison harness runner for CLI vs SDK implementations.

.DESCRIPTION
    Runs the same scenario(s) on both copilot-harness.ps1 (CLI) and
    copilot-harness-sdk.ts (SDK) and generates comparison report.

.PARAMETER ScenarioIds
    Comma-separated scenario IDs to run (e.g., "1,3,5" or "1-5")
    Default: 1-5 (first 5 scenarios)

.PARAMETER Model
    AI model to use (default: let Copilot choose)

.PARAMETER OutputDir
    Results directory (default: ./results)

.PARAMETER SkipCLI
    Skip CLI harness (only run SDK)

.PARAMETER SkipSDK
    Skip SDK harness (only run CLI)

.PARAMETER NoAnalyze
    Skip comparison analysis

.EXAMPLE
    .\compare-harnesses.ps1 -ScenarioIds "1,3,7"

.EXAMPLE
    .\compare-harnesses.ps1 -ScenarioIds "1-10" -Model "claude-opus-4.5"
#>

param(
    [string]$ScenarioIds = "1-5",
    [string]$Model,
    [string]$OutputDir = "./results",
    [switch]$SkipCLI,
    [switch]$SkipSDK,
    [switch]$NoAnalyze
)

$ErrorActionPreference = "Stop"

function Write-Header {
    param([string]$Text)
    Write-Host ""
    Write-Host "╔════════════════════════════════════════════════════════════════╗" -ForegroundColor Cyan
    Write-Host "║  $Text" -ForegroundColor Cyan
    Write-Host "╚════════════════════════════════════════════════════════════════╝" -ForegroundColor Cyan
    Write-Host ""
}

function Write-Section {
    param([string]$Text)
    Write-Host ""
    Write-Host "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" -ForegroundColor Gray
    Write-Host " $Text" -ForegroundColor Cyan
    Write-Host "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" -ForegroundColor Gray
    Write-Host ""
}

function Parse-ScenarioIds {
    param([string]$IdString)

    $ids = @()
    $parts = $IdString -split ","

    foreach ($part in $parts) {
        $part = $part.Trim()
        if ($part -match "^(\d+)-(\d+)$") {
            # Range like "1-5"
            $start = [int]$matches[1]
            $end = [int]$matches[2]
            $ids += ($start..$end)
        }
        elseif ($part -match "^\d+$") {
            # Single number
            $ids += [int]$part
        }
    }

    return $ids | Sort-Object -Unique
}

function Compare-Results {
    param(
        [string]$CliCsvFile,
        [string]$SdkCsvFile
    )

    Write-Section "📊 COMPARISON ANALYSIS"

    if (-not (Test-Path $CliCsvFile)) {
        Write-Host "⚠ CLI CSV not found: $CliCsvFile" -ForegroundColor Yellow
        return
    }

    if (-not (Test-Path $SdkCsvFile)) {
        Write-Host "⚠ SDK CSV not found: $SdkCsvFile" -ForegroundColor Yellow
        return
    }

    # Read results
    $cliResults = @{}
    $sdkResults = @{}

    Import-Csv $CliCsvFile | ForEach-Object {
        $scenarioName = $_.Scenario
        $cliResults[$scenarioName] = $_
    }

    Import-Csv $SdkCsvFile | ForEach-Object {
        $scenarioName = $_.Scenario
        $sdkResults[$scenarioName] = $_
    }

    # Common scenarios
    $commonScenarios = @($cliResults.Keys) | Where-Object { $sdkResults.ContainsKey($_) }

    Write-Host "Scenarios compared: $($commonScenarios.Count)"
    Write-Host ""

    if ($commonScenarios.Count -eq 0) {
        Write-Host "No common scenarios found to compare" -ForegroundColor Yellow
        return
    }

    # Build comparison table
    $comparisons = @()

    foreach ($scenario in $commonScenarios) {
        $cli = $cliResults[$scenario]
        $sdk = $sdkResults[$scenario]

        $cliDuration = [double]$cli.DurationSec
        $sdkDuration = [double]$sdk.DurationSec
        $speedup = [math]::Round($cliDuration / $sdkDuration, 2)

        $cliTools = [int]$cli.TotalToolCalls
        $sdkTools = [int]$sdk.TotalToolCalls
        $toolDiff = $cliTools - $sdkTools

        $comparisons += [PSCustomObject]@{
            Scenario    = $scenario -replace "^scenario_\d+_", ""
            CLIDuration = $cliDuration
            SDKDuration = $sdkDuration
            Speedup     = if ($sdkDuration -gt 0) { $speedup } else { "∞" }
            CLITools    = $cliTools
            SDKTools    = $sdkTools
            ToolDiff    = $toolDiff
            CLISuccess  = $cli.Success
            SDKSuccess  = $sdk.Success
        }
    }

    # Sort by speedup
    $comparisons = $comparisons | Sort-Object {
        if ($_.Speedup -eq "∞") { [double]::MaxValue } else { [double]$_.Speedup }
    } -Descending

    # Display table
    Write-Host "SCENARIO COMPARISON (sorted by SDK speedup):`n" -ForegroundColor White

    foreach ($comp in $comparisons) {
        $speedupStr = if ($comp.Speedup -eq "∞") { "N/A" } else { "$($comp.Speedup)x" }
        $speedupColor = if ($comp.Speedup -gt 1.2) { "Green" } elseif ($comp.Speedup -lt 0.8) { "Red" } else { "Gray" }

        Write-Host ("{0,-50} CLI: {1,6}s → SDK: {2,6}s  [{3}]" -f $comp.Scenario, $comp.CLIDuration, $comp.SDKDuration, $speedupStr) `
            -ForegroundColor Gray
        Write-Host ("  Tool calls: CLI {0,2} vs SDK {1,2} (diff: {2:+0;-0})" -f $comp.CLITools, $comp.SDKTools, $comp.ToolDiff) `
            -ForegroundColor DarkGray
    }

    # Summary statistics
    Write-Host ""
    Write-Host "SUMMARY STATISTICS:" -ForegroundColor White

    $validSpeedups = @($comparisons | Where-Object { $_.Speedup -ne "∞" } | ForEach-Object { [double]$_.Speedup })
    if ($validSpeedups.Count -gt 0) {
        $avgSpeedup = [math]::Round(($validSpeedups | Measure-Object -Average).Average, 2)
        $maxSpeedup = [math]::Round(($validSpeedups | Measure-Object -Maximum).Maximum, 2)
        $minSpeedup = [math]::Round(($validSpeedups | Measure-Object -Minimum).Minimum, 2)

        Write-Host "  Avg speedup: $avgSpeedup x" -ForegroundColor Cyan
        Write-Host "  Max speedup: $maxSpeedup x (SDK faster)" -ForegroundColor Green
        Write-Host "  Min speedup: $minSpeedup x (SDK slower)" -ForegroundColor Yellow
    }

    $cliSuccess = ($cliResults.Values | Where-Object { $_.Success -eq "true" }).Count
    $sdkSuccess = ($sdkResults.Values | Where-Object { $_.Success -eq "true" }).Count

    Write-Host "  CLI success rate: $cliSuccess/$($cliResults.Count)" -ForegroundColor Cyan
    Write-Host "  SDK success rate: $sdkSuccess/$($sdkResults.Count)" -ForegroundColor Cyan

    # Save comparison report
    $reportFile = Join-Path $OutputDir "comparison_report.txt"
    @"
═══════════════════════════════════════════════════════════════
COPILOT CLI vs SDK PERFORMANCE COMPARISON
Generated: $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
═══════════════════════════════════════════════════════════════

Summary Statistics:
  - Scenarios compared: $($commonScenarios.Count)
  - CLI success rate: $cliSuccess/$($cliResults.Count)
  - SDK success rate: $sdkSuccess/$($sdkResults.Count)
$(@"
  - Average speedup: $avgSpeedup x (positive = SDK faster)
  - Max speedup: $maxSpeedup x
  - Min speedup: $minSpeedup x
"@ | Where-Object { $validSpeedups.Count -gt 0 })

Detailed Results:
$($comparisons | Format-Table -AutoSize | Out-String)

Notes:
- Speedup > 1.0 means SDK is faster
- Speedup < 1.0 means CLI is faster
- ToolDiff shows additional tool calls (negative = SDK used fewer)
"@  | Out-File -FilePath $reportFile -Encoding UTF8

    Write-Host ""
    Write-Host "✓ Comparison report saved: $reportFile" -ForegroundColor Green
}

# ============================================================================
# MAIN
# ============================================================================

Write-Header "CLI vs SDK Harness Comparison"

# Parse scenario IDs
$scenarioIds = Parse-ScenarioIds $ScenarioIds
Write-Host "Running scenarios: $($scenarioIds -join ', ')" -ForegroundColor Cyan
Write-Host "Output directory: $OutputDir" -ForegroundColor Cyan
if ($Model) {
    Write-Host "Model: $Model" -ForegroundColor Cyan
}
Write-Host ""

# Run CLI harness
if (-not $SkipCLI) {
    Write-Section "🔴 Running CLI Harness (PowerShell)"

    foreach ($id in $scenarioIds) {
        $modelArg = if ($Model) { @("-Model", $Model) } else { @() }
        & .\copilot-harness.ps1 `
            -ScenarioFile scenarios.json `
            -ScenarioId $id `
            -OutputDir $OutputDir `
            @modelArg `
            -ErrorAction Continue

        Start-Sleep -Seconds 2  # Brief pause between scenarios
    }

    Write-Host "✓ CLI harness completed" -ForegroundColor Green
}

# Run SDK harness
if (-not $SkipSDK) {
    Write-Section "🔵 Running SDK Harness (Node.js/TypeScript)"

    # Check if npm modules are installed
    if (-not (Test-Path "node_modules/@github/copilot-sdk")) {
        Write-Host "Installing npm dependencies..." -ForegroundColor Yellow
        npm install
    }

    foreach ($id in $scenarioIds) {
        $modelArg = if ($Model) { @("--model", $Model) } else { @() }
        npx ts-node copilot-harness-sdk.ts `
            --scenario-file scenarios.json `
            --scenario-id $id `
            --output-dir $OutputDir `
            @modelArg

        Start-Sleep -Seconds 2  # Brief pause between scenarios
    }

    Write-Host "✓ SDK harness completed" -ForegroundColor Green
}

# Compare results
if (-not $NoAnalyze) {
    # Find latest CSV files for comparison
    $latestCliCsv = Get-ChildItem "$OutputDir/run_*_metrics.csv" -ErrorAction SilentlyContinue |
    Sort-Object LastWriteTime -Descending |
    Select-Object -First 1

    $latestSdkCsv = Get-ChildItem "$OutputDir/run_*_metrics.csv" -ErrorAction SilentlyContinue |
    Sort-Object LastWriteTime -Descending |
    Select-Object -First 2 |
    Select-Object -Last 1

    if ($latestCliCsv -and $latestSdkCsv -and $latestCliCsv.FullName -ne $latestSdkCsv.FullName) {
        Compare-Results -CliCsvFile $latestCliCsv.FullName -SdkCsvFile $latestSdkCsv.FullName
    }
}

Write-Host ""
Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
Write-Host "✓ Comparison complete!" -ForegroundColor Green
Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
Write-Host ""
Write-Host "Results saved to: $OutputDir" -ForegroundColor Gray
Write-Host "Next steps:" -ForegroundColor Cyan
Write-Host "  1. Review results files in $OutputDir" -ForegroundColor Gray
Write-Host "  2. Compare CSV files for detailed metrics" -ForegroundColor Gray
Write-Host "  3. Check comparison report for summary" -ForegroundColor Gray
Write-Host ""
