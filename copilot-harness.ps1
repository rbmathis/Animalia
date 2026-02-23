<#
.SYNOPSIS
    Harness for running Copilot CLI scenarios with telemetry.

.DESCRIPTION
    Runs prompts through GitHub Copilot CLI and captures:
    - Execution time
    - Tool calls (read_file, grep_search, etc.)
    - File operations count
    - Output for analysis

.PARAMETER Prompt
    Single prompt to run (alternative to -ScenarioFile)

.PARAMETER ScenarioFile
    Path to scenarios JSON file

.PARAMETER OutputDir
    Directory for results (default: ./results)

.PARAMETER ScenarioId
    Run only a specific scenario by ID (1-21)

.PARAMETER DryRun
    Show what would run without executing

.EXAMPLE
    .\copilot-harness.ps1 -Prompt "Find Canis_lupus and show its properties"

.EXAMPLE
    .\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

.EXAMPLE
    .\copilot-harness.ps1 -ScenarioFile scenarios.json -OutputDir ./results/run1
#>

param(
    [string]$Prompt,
    [string]$ScenarioFile,
    [string]$OutputDir = "./results",
    [int]$ScenarioId,
    [switch]$DryRun,
    [int]$TimeoutSeconds = 300
)

$ErrorActionPreference = "Stop"

# ============================================================================
# CONFIGURATION
# ============================================================================

# Copilot CLI command syntax:
#   copilot -p "PROMPT"   - Non-interactive mode with full output
#   copilot -sp "PROMPT"  - Silent mode (response only, no usage info)
# Docs: https://docs.github.com/en/copilot/how-tos/copilot-cli/cli-getting-started#using-github-copilot-cli-non-interactively

$COPILOT_CMD = "copilot"
# Copilot CLI uses ● bullet format: ● Glob, ● Read, ● Grep, ● Semantic Search, etc.
$TOOL_PATTERNS = @{
    "read_file"       = "● Read|read_file|Reading file"
    "grep_search"     = "● Grep|grep_search|Searching for"
    "semantic_search" = "● Semantic Search|semantic_search"
    "file_search"     = "● Glob|file_search|Finding files"
    "list_dir"        = "● List|list_dir|Listing directory"
    "create_file"     = "● Create|create_file|Creating file"
    "replace_string"  = "● Edit|● Replace|replace_string|Editing file"
    "run_terminal"    = "● Run|run_in_terminal|Running command"
}

# ============================================================================
# HELPER FUNCTIONS
# ============================================================================

function New-ResultsDir {
    param([string]$Path)
    if (-not (Test-Path $Path)) {
        New-Item -ItemType Directory -Path $Path -Force | Out-Null
    }
    return (Resolve-Path $Path).Path
}

function Get-Timestamp {
    return (Get-Date -Format "yyyy-MM-dd_HH-mm-ss")
}

function Parse-ToolCalls {
    param([string]$Output)

    $toolCounts = @{}
    foreach ($tool in $TOOL_PATTERNS.Keys) {
        $pattern = $TOOL_PATTERNS[$tool]
        $matches = [regex]::Matches($Output, $pattern, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
        $toolCounts[$tool] = $matches.Count
    }
    return $toolCounts
}

function Parse-FilesAccessed {
    param([string]$Output)

    # Extract file paths from Copilot CLI output
    # Format: ● Read path/to/file.cs or ● Glob "pattern"
    $files = @()

    # Match ● Read path/to/file.ext (files on same line after Read)
    $readPattern = '● Read\s+([^\r\n]+)'
    $readMatches = [regex]::Matches($Output, $readPattern)
    foreach ($match in $readMatches) {
        if ($match.Groups.Count -gt 1) {
            $files += $match.Groups[1].Value.Trim()
        }
    }

    # Also catch quoted paths
    $quotedPattern = '(?:read_file|Reading|Editing|Creating).*?["\x60]([^"\x60]+\.[a-z]+)["\x60]'
    $quotedMatches = [regex]::Matches($Output, $quotedPattern, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
    foreach ($match in $quotedMatches) {
        if ($match.Groups.Count -gt 1) {
            $files += $match.Groups[1].Value
        }
    }

    return $files | Select-Object -Unique
}

function Estimate-Tokens {
    param([string]$Text)
    # Rough estimate: ~4 chars per token
    return [math]::Ceiling($Text.Length / 4)
}

# ============================================================================
# RESOURCE MONITORING
# ============================================================================

function Get-ProcessResources {
    <#
    .SYNOPSIS
        Get resource usage for a process and its children
    #>
    param([System.Diagnostics.Process]$Process)

    try {
        $proc = Get-Process -Id $Process.Id -ErrorAction SilentlyContinue
        if (-not $proc) { return $null }

        # Get child processes too (node, etc.)
        $children = Get-CimInstance Win32_Process -Filter "ParentProcessId = $($Process.Id)" -ErrorAction SilentlyContinue
        $childProcs = @()
        foreach ($child in $children) {
            $cp = Get-Process -Id $child.ProcessId -ErrorAction SilentlyContinue
            if ($cp) { $childProcs += $cp }
        }

        $allProcs = @($proc) + $childProcs

        return @{
            WorkingSetMB = [math]::Round(($allProcs | Measure-Object -Property WorkingSet64 -Sum).Sum / 1MB, 2)
            PrivateMemMB = [math]::Round(($allProcs | Measure-Object -Property PrivateMemorySize64 -Sum).Sum / 1MB, 2)
            CpuTimeMs    = [math]::Round(($allProcs | ForEach-Object { $_.TotalProcessorTime.TotalMilliseconds } | Measure-Object -Sum).Sum, 0)
            ProcessCount = $allProcs.Count
        }
    }
    catch {
        return $null
    }
}

function Start-ResourceSampler {
    <#
    .SYNOPSIS
        Start a runspace-based sampler that writes to a synchronized collection
    #>
    param(
        [int]$ProcessId,
        [int]$IntervalMs = 500
    )

    $samples = [System.Collections.ArrayList]::Synchronized([System.Collections.ArrayList]::new())
    $stopFlag = [ref]$false

    $runspace = [runspacefactory]::CreateRunspace()
    $runspace.Open()
    $runspace.SessionStateProxy.SetVariable('ProcessId', $ProcessId)
    $runspace.SessionStateProxy.SetVariable('IntervalMs', $IntervalMs)
    $runspace.SessionStateProxy.SetVariable('Samples', $samples)
    $runspace.SessionStateProxy.SetVariable('StopFlag', $stopFlag)

    $ps = [powershell]::Create()
    $ps.Runspace = $runspace
    $ps.AddScript({
            while (-not $StopFlag.Value) {
                try {
                    $proc = Get-Process -Id $ProcessId -ErrorAction SilentlyContinue
                    if ($proc) {
                        $children = Get-CimInstance Win32_Process -Filter "ParentProcessId = $ProcessId" -ErrorAction SilentlyContinue
                        $totalMem = $proc.WorkingSet64
                        $procReadBytes = $proc.ReadTransferCount
                        $procWriteBytes = $proc.WriteTransferCount
                        foreach ($child in $children) {
                            $cp = Get-Process -Id $child.ProcessId -ErrorAction SilentlyContinue
                            if ($cp) {
                                $totalMem += $cp.WorkingSet64
                                $procReadBytes += $cp.ReadTransferCount
                                $procWriteBytes += $cp.WriteTransferCount
                            }
                        }

                        $cpu = (Get-Counter '\Processor(_Total)\% Processor Time' -ErrorAction SilentlyContinue).CounterSamples[0].CookedValue

                        # System-level disk I/O (bytes per second)
                        $diskCounters = Get-Counter -Counter @(
                            '\PhysicalDisk(_Total)\Disk Read Bytes/sec',
                            '\PhysicalDisk(_Total)\Disk Write Bytes/sec'
                        ) -ErrorAction SilentlyContinue
                        $sysReadBytesPerSec = 0
                        $sysWriteBytesPerSec = 0
                        if ($diskCounters) {
                            $sysReadBytesPerSec = $diskCounters.CounterSamples[0].CookedValue
                            $sysWriteBytesPerSec = $diskCounters.CounterSamples[1].CookedValue
                        }

                        $null = $Samples.Add(@{
                                Time                = (Get-Date).ToString('HH:mm:ss.fff')
                                CpuPercent          = [math]::Round($cpu, 2)
                                MemMB               = [math]::Round($totalMem / 1MB, 2)
                                ProcReadBytes       = $procReadBytes
                                ProcWriteBytes      = $procWriteBytes
                                SysReadBytesPerSec  = $sysReadBytesPerSec
                                SysWriteBytesPerSec = $sysWriteBytesPerSec
                            })
                    }
                }
                catch {}
                Start-Sleep -Milliseconds $IntervalMs
            }
        }) | Out-Null

    $handle = $ps.BeginInvoke()

    return @{
        PowerShell = $ps
        Handle     = $handle
        Runspace   = $runspace
        Samples    = $samples
        StopFlag   = $stopFlag
        IntervalMs = $IntervalMs
    }
}

function Stop-ResourceSampler {
    <#
    .SYNOPSIS
        Stop sampler and return aggregated metrics
    #>
    param($Sampler)

    try {
        $Sampler.StopFlag.Value = $true
        Start-Sleep -Milliseconds 100
        $Sampler.PowerShell.Stop()
        $Sampler.Runspace.Close()
    }
    catch {}

    $samples = @($Sampler.Samples)

    if ($samples.Count -eq 0) {
        return @{
            SampleCount = 0
            CpuAvg      = 0
            CpuMax      = 0
            MemAvgMB    = 0
            MemMaxMB    = 0
            ProcReadMB  = 0
            ProcWriteMB = 0
            SysReadMB   = 0
            SysWriteMB  = 0
        }
    }

    # Process I/O: difference between last and first sample
    $firstSample = $samples[0]
    $lastSample = $samples[$samples.Count - 1]
    $procReadBytes = [math]::Max(0, $lastSample.ProcReadBytes - $firstSample.ProcReadBytes)
    $procWriteBytes = [math]::Max(0, $lastSample.ProcWriteBytes - $firstSample.ProcWriteBytes)

    # System I/O: sum of (bytes/sec * interval) across samples
    $intervalSec = $Sampler.IntervalMs / 1000.0
    $sysReadBytes = ($samples | ForEach-Object { $_.SysReadBytesPerSec * $intervalSec } | Measure-Object -Sum).Sum
    $sysWriteBytes = ($samples | ForEach-Object { $_.SysWriteBytesPerSec * $intervalSec } | Measure-Object -Sum).Sum

    return @{
        SampleCount = $samples.Count
        CpuAvg      = [math]::Round(($samples | ForEach-Object { $_.CpuPercent } | Measure-Object -Average).Average, 2)
        CpuMax      = [math]::Round(($samples | ForEach-Object { $_.CpuPercent } | Measure-Object -Maximum).Maximum, 2)
        MemAvgMB    = [math]::Round(($samples | ForEach-Object { $_.MemMB } | Measure-Object -Average).Average, 2)
        MemMaxMB    = [math]::Round(($samples | ForEach-Object { $_.MemMB } | Measure-Object -Maximum).Maximum, 2)
        ProcReadMB  = [math]::Round($procReadBytes / 1MB, 2)
        ProcWriteMB = [math]::Round($procWriteBytes / 1MB, 2)
        SysReadMB   = [math]::Round($sysReadBytes / 1MB, 2)
        SysWriteMB  = [math]::Round($sysWriteBytes / 1MB, 2)
    }
}

function Run-CopilotPrompt {
    param(
        [string]$PromptText,
        [int]$Timeout = 300
    )

    $result = @{
        Prompt                = $PromptText
        StartTime             = Get-Date
        EndTime               = $null
        DurationMs            = 0
        ExitCode              = 0
        Output                = ""
        Error                 = ""
        ToolCalls             = @{}
        FilesAccessed         = @()
        EstimatedInputTokens  = 0
        EstimatedOutputTokens = 0
        Success               = $false
        Resources             = @{}
    }

    $result.EstimatedInputTokens = Estimate-Tokens $PromptText

    # Create temp file for output capture
    $tempOut = [System.IO.Path]::GetTempFileName()
    $tempErr = [System.IO.Path]::GetTempFileName()

    try {
        $stopwatch = [System.Diagnostics.Stopwatch]::StartNew()

        # Run copilot with prompt using pwsh since copilot is a PS1 script
        # -p flag for non-interactive prompt mode
        # -s flag can be added for silent output (response only)
        # See: https://docs.github.com/en/copilot/how-tos/copilot-cli/cli-getting-started#using-github-copilot-cli-non-interactively
        $escapedPrompt = $PromptText -replace '"', '\"' -replace "'", "''"
        $process = Start-Process -FilePath "pwsh" `
            -ArgumentList "-NoProfile", "-Command", "& copilot -p '$escapedPrompt'" `
            -RedirectStandardOutput $tempOut `
            -RedirectStandardError $tempErr `
            -NoNewWindow `
            -PassThru

        # Start resource sampler now that we have process ID
        $sampler = Start-ResourceSampler -ProcessId $process.Id -IntervalMs 500

        # Wait with timeout
        $completed = $process.WaitForExit($Timeout * 1000)

        $stopwatch.Stop()
        $result.EndTime = Get-Date
        $result.DurationMs = $stopwatch.ElapsedMilliseconds

        # Collect resource metrics before process cleanup
        $result.Resources = Stop-ResourceSampler -Sampler $sampler

        if (-not $completed) {
            $process.Kill()
            $result.Error = "TIMEOUT after ${Timeout}s"
            $result.ExitCode = -1
        }
        else {
            $result.ExitCode = $process.ExitCode
            $result.Success = ($process.ExitCode -eq 0)
        }

        # Read output
        $result.Output = Get-Content $tempOut -Raw -ErrorAction SilentlyContinue
        $result.Error += Get-Content $tempErr -Raw -ErrorAction SilentlyContinue

        # Parse telemetry
        if ($result.Output) {
            $result.ToolCalls = Parse-ToolCalls $result.Output
            $result.FilesAccessed = Parse-FilesAccessed $result.Output
            $result.EstimatedOutputTokens = Estimate-Tokens $result.Output
        }

    }
    finally {
        Remove-Item $tempOut -ErrorAction SilentlyContinue
        Remove-Item $tempErr -ErrorAction SilentlyContinue
    }

    return $result
}

function Export-Result {
    param(
        [hashtable]$Result,
        [string]$OutputDir,
        [string]$ScenarioName
    )

    $timestamp = Get-Timestamp
    $safeName = $ScenarioName -replace '[^\w\-]', '_'

    # Save full output
    $outputFile = Join-Path $OutputDir "${safeName}_${timestamp}_output.txt"
    $Result.Output | Out-File -FilePath $outputFile -Encoding UTF8

    # Save metrics as JSON
    $metricsFile = Join-Path $OutputDir "${safeName}_${timestamp}_metrics.json"
    $metrics = @{
        scenario              = $ScenarioName
        timestamp             = $timestamp
        prompt                = $Result.Prompt
        durationMs            = $Result.DurationMs
        durationSec           = [math]::Round($Result.DurationMs / 1000, 2)
        exitCode              = $Result.ExitCode
        success               = $Result.Success
        toolCalls             = $Result.ToolCalls
        totalToolCalls        = ($Result.ToolCalls.Values | Measure-Object -Sum).Sum
        filesAccessed         = $Result.FilesAccessed
        fileCount             = $Result.FilesAccessed.Count
        estimatedInputTokens  = $Result.EstimatedInputTokens
        estimatedOutputTokens = $Result.EstimatedOutputTokens
        estimatedTotalTokens  = $Result.EstimatedInputTokens + $Result.EstimatedOutputTokens
        resources             = $Result.Resources
        error                 = $Result.Error
    }
    $metrics | ConvertTo-Json -Depth 5 | Out-File -FilePath $metricsFile -Encoding UTF8

    return @{
        OutputFile  = $outputFile
        MetricsFile = $metricsFile
        Metrics     = $metrics
    }
}

function Show-Summary {
    param([hashtable]$Metrics)

    Write-Host ""
    Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Cyan
    Write-Host " SCENARIO: $($Metrics.scenario)" -ForegroundColor White
    Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Cyan
    Write-Host ""

    $status = if ($Metrics.success) { "✓ SUCCESS" } else { "✗ FAILED" }
    $statusColor = if ($Metrics.success) { "Green" } else { "Red" }
    Write-Host " Status:    $status" -ForegroundColor $statusColor
    Write-Host " Duration:  $($Metrics.durationSec)s ($($Metrics.durationMs)ms)" -ForegroundColor Gray
    Write-Host ""

    Write-Host " Tool Calls:" -ForegroundColor Yellow
    foreach ($tool in $Metrics.toolCalls.Keys | Sort-Object) {
        $count = $Metrics.toolCalls[$tool]
        if ($count -gt 0) {
            Write-Host "   • $tool`: $count" -ForegroundColor Gray
        }
    }
    Write-Host "   ─────────────────" -ForegroundColor DarkGray
    Write-Host "   Total: $($Metrics.totalToolCalls)" -ForegroundColor White
    Write-Host ""

    Write-Host " Files Accessed: $($Metrics.fileCount)" -ForegroundColor Yellow
    foreach ($file in $Metrics.filesAccessed | Select-Object -First 5) {
        Write-Host "   • $file" -ForegroundColor Gray
    }
    if ($Metrics.fileCount -gt 5) {
        Write-Host "   ... and $($Metrics.fileCount - 5) more" -ForegroundColor DarkGray
    }
    Write-Host ""

    Write-Host " Estimated Tokens:" -ForegroundColor Yellow
    Write-Host "   Input:  $($Metrics.estimatedInputTokens)" -ForegroundColor Gray
    Write-Host "   Output: $($Metrics.estimatedOutputTokens)" -ForegroundColor Gray
    Write-Host "   Total:  $($Metrics.estimatedTotalTokens)" -ForegroundColor White
    Write-Host ""

    if ($Metrics.resources -and $Metrics.resources.SampleCount -gt 0) {
        Write-Host " System Resources:" -ForegroundColor Yellow
        Write-Host "   CPU:        avg $($Metrics.resources.CpuAvg)% / max $($Metrics.resources.CpuMax)%" -ForegroundColor Gray
        Write-Host "   Memory:     avg $($Metrics.resources.MemAvgMB) MB / max $($Metrics.resources.MemMaxMB) MB" -ForegroundColor Gray
        Write-Host "   Disk (sys): read $($Metrics.resources.SysReadMB) MB / write $($Metrics.resources.SysWriteMB) MB" -ForegroundColor Gray
        Write-Host "   Disk (proc): read $($Metrics.resources.ProcReadMB) MB / write $($Metrics.resources.ProcWriteMB) MB" -ForegroundColor Gray
        Write-Host "   Samples:    $($Metrics.resources.SampleCount)" -ForegroundColor DarkGray
        Write-Host ""
    }
}

function Load-Scenarios {
    param([string]$FilePath)

    if (-not (Test-Path $FilePath)) {
        throw "Scenario file not found: $FilePath"
    }

    return Get-Content $FilePath -Raw | ConvertFrom-Json
}

# ============================================================================
# MAIN
# ============================================================================

Write-Host ""
Write-Host "╔═══════════════════════════════════════════════════════════════╗" -ForegroundColor Magenta
Write-Host "║          COPILOT CLI SCENARIO HARNESS                         ║" -ForegroundColor Magenta
Write-Host "║          Telemetry & Benchmarking Tool                        ║" -ForegroundColor Magenta
Write-Host "╚═══════════════════════════════════════════════════════════════╝" -ForegroundColor Magenta
Write-Host ""

# Verify Copilot CLI is available
try {
    $version = & $COPILOT_CMD --version 2>&1
    Write-Host "✓ Copilot CLI detected: $version" -ForegroundColor Green
}
catch {
    Write-Host "✗ Copilot CLI not found. Install from: https://github.com/features/copilot/cli/" -ForegroundColor Red
    exit 1
}

# Create output directory
$outputPath = New-ResultsDir $OutputDir
Write-Host "✓ Results directory: $outputPath" -ForegroundColor Green
Write-Host ""

# Run scenarios
$allResults = @()
$allOutputs = @()
$runTimestamp = Get-Timestamp

if ($Prompt) {
    # Single prompt mode
    Write-Host "Running single prompt..." -ForegroundColor Yellow

    if ($DryRun) {
        Write-Host "[DRY RUN] Would execute: $Prompt" -ForegroundColor Cyan
    }
    else {
        $result = Run-CopilotPrompt -PromptText $Prompt -Timeout $TimeoutSeconds
        $usedBreadcrumbs = ($result.FilesAccessed | Where-Object { $_ -match 'breadcrumb\.md' }).Count -gt 0
        $metrics = @{
            scenario              = "adhoc"
            timestamp             = $runTimestamp
            prompt                = $result.Prompt
            durationMs            = $result.DurationMs
            durationSec           = [math]::Round($result.DurationMs / 1000, 2)
            exitCode              = $result.ExitCode
            success               = $result.Success
            toolCalls             = $result.ToolCalls
            totalToolCalls        = ($result.ToolCalls.Values | Measure-Object -Sum).Sum
            filesAccessed         = $result.FilesAccessed
            fileCount             = $result.FilesAccessed.Count
            usedBreadcrumbs       = $usedBreadcrumbs
            estimatedInputTokens  = $result.EstimatedInputTokens
            estimatedOutputTokens = $result.EstimatedOutputTokens
            estimatedTotalTokens  = $result.EstimatedInputTokens + $result.EstimatedOutputTokens
            resources             = $result.Resources
            error                 = $result.Error
        }
        Show-Summary $metrics
        $allResults += $metrics
        $allOutputs += "=== SCENARIO: adhoc ==="
        $allOutputs += $result.Output
    }

}
elseif ($ScenarioFile) {
    # Scenario file mode
    $scenarios = Load-Scenarios $ScenarioFile

    Write-Host "Loaded $($scenarios.Count) scenarios from $ScenarioFile" -ForegroundColor Yellow
    Write-Host ""

    foreach ($scenario in $scenarios) {
        # Filter by ID if specified
        if ($ScenarioId -and $scenario.id -ne $ScenarioId) {
            continue
        }

        Write-Host "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" -ForegroundColor DarkGray
        Write-Host "Running scenario $($scenario.id): $($scenario.name)" -ForegroundColor Cyan
        Write-Host "Prompt: $($scenario.prompt)" -ForegroundColor Gray
        Write-Host ""

        if ($DryRun) {
            Write-Host "[DRY RUN] Would execute scenario $($scenario.id)" -ForegroundColor Cyan
        }
        else {
            $result = Run-CopilotPrompt -PromptText $scenario.prompt -Timeout $TimeoutSeconds
            $scenarioName = "scenario_$($scenario.id)_$($scenario.name)"
            $usedBreadcrumbs = ($result.FilesAccessed | Where-Object { $_ -match 'breadcrumb\.md' }).Count -gt 0
            $metrics = @{
                scenario              = $scenarioName
                timestamp             = $runTimestamp
                prompt                = $result.Prompt
                durationMs            = $result.DurationMs
                durationSec           = [math]::Round($result.DurationMs / 1000, 2)
                exitCode              = $result.ExitCode
                success               = $result.Success
                toolCalls             = $result.ToolCalls
                totalToolCalls        = ($result.ToolCalls.Values | Measure-Object -Sum).Sum
                filesAccessed         = $result.FilesAccessed
                fileCount             = $result.FilesAccessed.Count
                usedBreadcrumbs       = $usedBreadcrumbs
                estimatedInputTokens  = $result.EstimatedInputTokens
                estimatedOutputTokens = $result.EstimatedOutputTokens
                estimatedTotalTokens  = $result.EstimatedInputTokens + $result.EstimatedOutputTokens
                resources             = $result.Resources
                error                 = $result.Error
            }
            Show-Summary $metrics
            $allResults += $metrics
            $allOutputs += "`n`n==============================================================================="
            $allOutputs += "=== SCENARIO $($scenario.id): $($scenario.name)"
            $allOutputs += "===============================================================================`n"
            $allOutputs += $result.Output
        }
    }

}
else {
    Write-Host "Usage:" -ForegroundColor Yellow
    Write-Host "  .\copilot-harness.ps1 -Prompt 'Your prompt here'" -ForegroundColor Gray
    Write-Host "  .\copilot-harness.ps1 -ScenarioFile scenarios.json" -ForegroundColor Gray
    Write-Host "  .\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1" -ForegroundColor Gray
    Write-Host ""
    exit 0
}

# Export consolidated results (single file per run)
if ($allResults.Count -gt 0) {
    # Single output file with all scenario outputs
    $outputFile = Join-Path $outputPath "run_${runTimestamp}_output.txt"
    $allOutputs -join "`n" | Out-File -FilePath $outputFile -Encoding UTF8

    # Single metrics file with all scenario metrics
    $metricsFile = Join-Path $outputPath "run_${runTimestamp}_metrics.json"
    @{
        runTimestamp     = $runTimestamp
        scenarioCount    = $allResults.Count
        totalDurationSec = [math]::Round(($allResults | ForEach-Object { $_.durationSec } | Measure-Object -Sum).Sum, 2)
        successCount     = ($allResults | Where-Object { $_.success } | Measure-Object).Count
        scenarios        = $allResults
    } | ConvertTo-Json -Depth 5 | Out-File -FilePath $metricsFile -Encoding UTF8

    # Also export as CSV for easy analysis
    $csvFile = Join-Path $outputPath "run_${runTimestamp}_metrics.csv"
    $allResults | ForEach-Object {
        [PSCustomObject]@{
            Scenario        = $_.scenario
            DurationSec     = $_.durationSec
            Success         = $_.success
            UsedBreadcrumbs = $_.usedBreadcrumbs
            TotalToolCalls  = $_.totalToolCalls
            ReadFileCalls   = $_.toolCalls.read_file
            GrepSearchCalls = $_.toolCalls.grep_search
            FileCount       = $_.fileCount
            EstimatedTokens = $_.estimatedTotalTokens
            CpuAvg          = $_.resources.CpuAvg
            CpuMax          = $_.resources.CpuMax
            MemAvgMB        = $_.resources.MemAvgMB
            MemMaxMB        = $_.resources.MemMaxMB
            SysReadMB       = $_.resources.SysReadMB
            SysWriteMB      = $_.resources.SysWriteMB
            ProcReadMB      = $_.resources.ProcReadMB
            ProcWriteMB     = $_.resources.ProcWriteMB
        }
    } | Export-Csv -Path $csvFile -NoTypeInformation

    Write-Host ""
    Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
    Write-Host " COMPLETE: $($allResults.Count) scenario(s) executed" -ForegroundColor Green
    Write-Host " Output:   $outputFile" -ForegroundColor Gray
    Write-Host " Metrics:  $metricsFile" -ForegroundColor Gray
    Write-Host " CSV:      $csvFile" -ForegroundColor Gray
    Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
}
