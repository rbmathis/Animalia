<#
.SYNOPSIS
    Builds C# projects in the Animal Kingdom repository.

.DESCRIPTION
    This script builds .csproj files at various levels of the taxonomy hierarchy.
    Since the repo has 15,000+ project files, building everything takes time.
    Use -Level to control build granularity.

.PARAMETER Level
    The taxonomy level to build at:
    - "family"  : Build all family-level projects (fastest, ~100 projects)
    - "genus"   : Build all genus-level projects (~1,500 projects)
    - "all"     : Build all projects (~15,000 projects, very slow)
    - "root"    : Build just the root project
    Default: "family"

.PARAMETER Path
    Specific path pattern to build (e.g., "**/Canidae/**")
    Default: builds based on -Level

.PARAMETER Parallel
    Number of parallel builds. Default: 4

.PARAMETER StopOnError
    Stop building if any project fails. Default: false (continue and report)

.EXAMPLE
    .\build-all.ps1
    # Builds all family-level projects

.EXAMPLE
    .\build-all.ps1 -Level genus
    # Builds all genus-level projects

.EXAMPLE
    .\build-all.ps1 -Path "**/Carnivora/**"
    # Builds all projects under Carnivora order

.EXAMPLE
    .\build-all.ps1 -Level family -Parallel 8
    # Builds families with 8 parallel jobs
#>

param(
    [ValidateSet("family", "genus", "all", "root")]
    [string]$Level = "family",
    
    [string]$Path = "",
    
    [int]$Parallel = 4,
    
    [switch]$StopOnError,
    
    [switch]$Clean,
    
    [switch]$Verbose
)

$ErrorActionPreference = "Continue"
$startTime = Get-Date

Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "  Animal Kingdom Build Script" -ForegroundColor Cyan
Write-Host "========================================`n" -ForegroundColor Cyan

# Clean if requested
if ($Clean) {
    Write-Host "Cleaning bin/obj folders..." -ForegroundColor Yellow
    Get-ChildItem -Path "root" -Recurse -Directory -Include "bin", "obj" | Remove-Item -Recurse -Force -ErrorAction SilentlyContinue
    Write-Host "Clean complete.`n" -ForegroundColor Green
}

# Find projects based on level
function Get-ProjectsByLevel {
    param([string]$Level, [string]$CustomPath)
    
    if ($CustomPath) {
        return Get-ChildItem -Path "root" -Recurse -Filter "*.csproj" | 
            Where-Object { $_.FullName -like "*$CustomPath*" }
    }
    
    switch ($Level) {
        "root" {
            return Get-Item "root\root.csproj"
        }
        "family" {
            # Families are typically 5-6 levels deep (root/Metazoa/Chordata/Class/Order/Family)
            # They have children folders (genera) but are not genus-level themselves
            return Get-ChildItem -Path "root" -Recurse -Filter "*.csproj" | Where-Object {
                $depth = ($_.DirectoryName -replace "\\", "/" -split "/").Count
                $hasChildren = (Get-ChildItem -Path $_.DirectoryName -Directory -ErrorAction SilentlyContinue | 
                    Where-Object { $_.Name -notmatch "bin|obj" }).Count -gt 0
                # Family projects: have child folders (genera) and reasonable depth
                $depth -ge 6 -and $depth -le 8 -and $hasChildren
            }
        }
        "genus" {
            # Genus projects: contain species files (files with underscore)
            return Get-ChildItem -Path "root" -Recurse -Filter "*.csproj" | Where-Object {
                $speciesFiles = Get-ChildItem -Path $_.DirectoryName -Filter "*_*.cs" -ErrorAction SilentlyContinue
                $speciesFiles.Count -gt 0
            }
        }
        "all" {
            return Get-ChildItem -Path "root" -Recurse -Filter "*.csproj"
        }
    }
}

Write-Host "Finding projects at level: $Level" -ForegroundColor Yellow
$projects = @(Get-ProjectsByLevel -Level $Level -CustomPath $Path)
Write-Host "Found $($projects.Count) projects to build`n" -ForegroundColor Green

if ($projects.Count -eq 0) {
    Write-Host "No projects found matching criteria." -ForegroundColor Red
    exit 1
}

# Build tracking
$results = [System.Collections.Concurrent.ConcurrentBag[PSObject]]::new()
$completed = 0
$failed = 0

# Build function
$buildScript = {
    param($project)
    
    $stopwatch = [System.Diagnostics.Stopwatch]::StartNew()
    $output = dotnet build $project.FullName --verbosity quiet --nologo 2>&1
    $stopwatch.Stop()
    
    $success = $LASTEXITCODE -eq 0
    $errors = $output | Select-String "error CS" | Select-Object -ExpandProperty Line
    
    [PSCustomObject]@{
        Project = $project.Name
        Path = $project.DirectoryName -replace [regex]::Escape((Get-Location).Path + "\"), ""
        Success = $success
        Duration = $stopwatch.Elapsed.TotalSeconds
        Errors = $errors -join "; "
    }
}

# Sequential or parallel build
if ($Parallel -le 1 -or $projects.Count -le 5) {
    # Sequential build
    Write-Host "Building sequentially..." -ForegroundColor Yellow
    foreach ($project in $projects) {
        $completed++
        $pct = [math]::Round(($completed / $projects.Count) * 100)
        Write-Progress -Activity "Building" -Status "$completed of $($projects.Count) - $($project.Name)" -PercentComplete $pct
        
        $result = & $buildScript $project
        $results.Add($result)
        
        if (-not $result.Success) {
            $failed++
            Write-Host "  FAILED: $($result.Path)" -ForegroundColor Red
            if ($Verbose) { Write-Host "    $($result.Errors)" -ForegroundColor Yellow }
            if ($StopOnError) { break }
        } elseif ($Verbose) {
            Write-Host "  OK: $($result.Path) ($([math]::Round($result.Duration, 1))s)" -ForegroundColor Green
        }
    }
    Write-Progress -Activity "Building" -Completed
} else {
    # Parallel build using jobs
    Write-Host "Building with $Parallel parallel jobs..." -ForegroundColor Yellow
    
    $projects | ForEach-Object -ThrottleLimit $Parallel -Parallel {
        $project = $_
        $stopwatch = [System.Diagnostics.Stopwatch]::StartNew()
        $output = dotnet build $project.FullName --verbosity quiet --nologo 2>&1
        $stopwatch.Stop()
        
        $success = $LASTEXITCODE -eq 0
        $errors = $output | Select-String "error CS" | Select-Object -ExpandProperty Line
        
        [PSCustomObject]@{
            Project = $project.Name
            Path = $project.DirectoryName -replace [regex]::Escape($using:PWD.Path + "\"), ""
            Success = $success
            Duration = $stopwatch.Elapsed.TotalSeconds
            Errors = $errors -join "; "
        }
    } | ForEach-Object {
        $results.Add($_)
        $completed++
        if (-not $_.Success) {
            $failed++
            Write-Host "  FAILED: $($_.Path)" -ForegroundColor Red
        }
    }
}

# Summary
$totalTime = ((Get-Date) - $startTime).TotalSeconds
$successCount = $results.Count - $failed

Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "  Build Summary" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  Total projects:  $($projects.Count)"
Write-Host "  Succeeded:       $successCount" -ForegroundColor Green
Write-Host "  Failed:          $failed" -ForegroundColor $(if ($failed -gt 0) { "Red" } else { "Green" })
Write-Host "  Total time:      $([math]::Round($totalTime, 1))s"
Write-Host "========================================`n" -ForegroundColor Cyan

# Show failures
if ($failed -gt 0) {
    Write-Host "Failed projects:" -ForegroundColor Red
    $results | Where-Object { -not $_.Success } | ForEach-Object {
        Write-Host "  - $($_.Path)" -ForegroundColor Yellow
        if ($_.Errors) {
            Write-Host "    $($_.Errors)" -ForegroundColor DarkYellow
        }
    }
    Write-Host ""
}

# Export results
$resultsFile = "build-results-$(Get-Date -Format 'yyyy-MM-dd_HH-mm-ss').json"
$results | ConvertTo-Json -Depth 3 | Set-Content $resultsFile
Write-Host "Results saved to: $resultsFile" -ForegroundColor Gray

exit $(if ($failed -gt 0) { 1 } else { 0 })
