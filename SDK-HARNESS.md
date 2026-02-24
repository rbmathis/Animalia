# Copilot SDK vs CLI Performance Comparison Harness

This directory contains two implementations of a Copilot scenario harness for benchmarking:

1. **`copilot-harness.ps1`** - PowerShell with Copilot CLI (`copilot -p`)
2. **`copilot-harness-sdk-esm.mjs`** - Node.js/JavaScript with Copilot SDK

## Overview

Both harnesses execute the same scenarios and collect identical metrics, enabling fair performance comparison between:
- **CLI approach**: PowerShell spawning the Copilot CLI process and parsing text output
- **SDK approach**: Node.js direct programmatic integration via Copilot SDK (with persistent sessions)

## Quick Start

### Using the CLI Harness (PowerShell)

```powershell
# Run all scenarios
.\copilot-harness.ps1 -ScenarioFile scenarios.json

# Run single scenario
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

# Specify model
.\copilot-harness.ps1 -ScenarioFile scenarios.json -Model 'claude-opus-4.5'

# Dry run (see what would execute without running)
.\copilot-harness.ps1 -ScenarioFile scenarios.json -DryRun
```

### Using the SDK Harness (Node.js/JavaScript)

```bash
# Install dependencies (first time only)
npm install

# Run all scenarios
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json

# Run single scenario
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1

# Specify model
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --model 'claude-opus-4.5'

# Dry run
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --dry-run
```

## Architecture Comparison

### PowerShell CLI Harness

```
Your Script (PowerShell)
       ↓
Start-Process (copilot CLI)
       ↓
Parse stdout/stderr text
       ↓
Extract tool calls via regex
       ↓
Collect metrics & resource usage
```

**Pros:**
- ✅ Works on Windows/Linux/Mac
- ✅ Detailed resource sampling (CPU, memory, disk I/O)
- ✅ Captures all CLI output
- ✅ Flexible process management

**Cons:**
- ❌ Text parsing is fragile
- ❌ Indirect tool call tracking
- ❌ Process overhead
- ❌ Serialization/deserialization latency

### Node.js/JavaScript SDK Harness

```
Your App (Node.js/JavaScript)
       ↓
SDK Client (JSON-RPC)
       ↓
Copilot CLI (server mode)
       ↓
Direct event handlers
       ↓
Structured tool metrics
```

**Pros:**
- ✅ Direct programmatic access
- ✅ Event-based tool tracking
- ✅ Structured message types
- ✅ Built-in streaming support
- ✅ Lower latency (no text parsing)
- ✅ Persistent session reuse (optimized)

**Cons:**
- ❌ Node.js dependency
- ❌ Simpler resource metrics (currently)

## Metrics Collected

Both harnesses collect identical top-level metrics:

| Metric | Description |
|--------|-------------|
| `durationSec` | Total execution time in seconds |
| `success` | Whether scenario completed without error |
| `toolCalls` | Breakdown by tool type (read_file, grep_search, etc.) |
| `totalToolCalls` | Sum of all tool calls |
| `filesAccessed` | List of files accessed during execution |
| `fileCount` | Number of unique files accessed |
| `usedBreadcrumbs` | Whether breadcrumb.md files were accessed |
| `estimatedTokens` | Input + output token estimate (chars ÷ 4) |
| `resources.cpuAvg` | Average CPU usage during execution |
| `resources.memAvgMB` | Average memory usage in MB |

## Output Formats

Both harnesses produce identical output files with timestamp:

```
results/
├── run_2026-02-24_15-30-45_output.txt     # Consolidated output
├── run_2026-02-24_15-30-45_metrics.json   # Full metrics + tool breakdown
└── run_2026-02-24_15-30-45_metrics.csv    # CSV for spreadsheet analysis
```

### JSON Metrics Structure

```json
{
  "runTimestamp": "2026-02-24_15-30-45",
  "scenarioCount": 30,
  "totalDurationSec": 1250.45,
  "successCount": 28,
  "scenarios": [
    {
      "scenario": "scenario_1_Fix_Incorrect_Conservation_Status",
      "timestamp": "2026-02-24_15-30-45",
      "model": "claude-opus-4.5",
      "durationSec": 42.15,
      "success": true,
      "usedBreadcrumbs": true,
      "toolCalls": {
        "read_file": 12,
        "grep_search": 8,
        "semantic_search": 0,
        "file_search": 0,
        "list_dir": 2,
        "create_file": 0,
        "replace_string": 1,
        "run_terminal": 0
      },
      "totalToolCalls": 23,
      "fileCount": 15,
      "estimatedTotalTokens": 8420,
      "resources": {
        "cpuAvg": 45.2,
        "memAvgMB": 256.4
      }
    }
  ]
}
```

## Performance Comparison

Run identical scenarios with both harnesses and compare results:

```bash
# Run scenario 1 with CLI
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

# Run scenario 1 with SDK
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1

# Compare results/run_*_metrics.json files
```

Expected differences:
- **SDK often faster** due to no text parsing overhead
- **CLI may use fewer files** if caching works differently
- **Token estimates identical** (both use chars ÷ 4)
- **Tool call counts** may differ slightly due to detection methods

## Installation

### CLI Harness (PowerShell)
- PowerShell 7+ installed
- GitHub Copilot CLI installed (`copilot` available in PATH)

### SDK Harness (Node.js)
```bash
npm install
```

Requires:
- Node.js >= 18.0.0
- GitHub Copilot CLI installed (SDK communicates via JSON-RPC)

## Implementation Notes

### Tool Call Detection

**CLI Method (PowerShell):**
```powershell
# Text pattern matching
$matches = [regex]::Matches($Output, "● Read|read_file|Reading file", ...)
```

**SDK Method (JavaScript):**
```javascript
// Event handlers + output parsing
session.on("tool.execution_complete", (event) => {
  const toolName = event.data.toolName; // Direct access
});
```

### File Access Tracking

Both harnesses parse output text for file paths, but SDK may have more direct access depending on event availability.

### Resource Monitoring

- **CLI**: Runspace-based sampling at 500ms intervals
- **SDK**: Process-level metrics via Node.js `process.memoryUsage()` and `process.cpuUsage()`

Future enhancement: Implement finer-grained resource tracking in SDK version.

## Scenarios

Scenarios are shared between both harnesses via `scenarios.json`. Each scenario includes:
- **id**: Numeric identifier (1-30)
- **name**: Scenario name
- **category**: Bug fix, feature, documentation, etc.
- **prompt**: The exact prompt sent to Copilot

See [scenarios.md](scenarios.md) for detailed descriptions.

## Troubleshooting

### CLI Harness Issues
- **"copilot" not found**: Ensure GitHub Copilot CLI is installed and in PATH
- **Timeout errors**: Increase `-TimeoutSeconds` parameter (default 300s)
- **Parse errors**: Check if Copilot CLI output format changed

### SDK Harness Issues
- **Module not found**: Run `npm install` first
- **Cannot connect to CLI**: Ensure Copilot CLI is installed

## Suggested Comparison Workflow

1. **Baseline Run**
   ```bash
   # CLI version
   .\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1-5

   # SDK version
   node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1
   node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 2
   # ... etc
   ```

2. **Compare output files**
   ```bash
   # Compare metrics/times
   diff results/run_*_metrics.csv
   ```

3. **Analyze differences**
   - Tool call counts
   - File access patterns
   - Token usage
   - Success rates
   - Breadcrumb usage

4. **Track improvements**
   - Which SDK optimizations help?
   - Where does CLI excel?
   - What scenarios fail on which platform?

## Future Enhancements

- [ ] Better resource tracking in SDK version (disk I/O, CPU per-thread)
- [ ] Session caching comparison
- [ ] Streaming performance metrics
- [ ] Model-specific performance analysis
- [ ] Tool hook instrumentation in SDK version
- [ ] Batch scenario execution with concurrent sessions

## License

MIT - Same as Copilot SDK

## References

- [GitHub Copilot SDK Docs](https://github.com/github/copilot-sdk)
- [Copilot CLI Installation](https://docs.github.com/en/copilot/how-tos/set-up/install-copilot-cli)
- [Scenarios Documentation](scenarios.md)
