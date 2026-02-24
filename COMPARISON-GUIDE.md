# Copilot CLI vs SDK Performance Comparison

This guide explains how to run and compare the two harness implementations: **CLI** (PowerShell with `copilot -p`) vs **SDK** (Node.js/JavaScript).

## 📋 Files Overview

| File | Type | Purpose |
|------|------|----------|
| `copilot-harness.ps1` | PowerShell | CLI-based harness (using `copilot -p`) |
| `copilot-harness-sdk-esm.mjs` | JavaScript | SDK-based harness (using Copilot SDK) |
| `compare-harnesses.ps1` | PowerShell | Automated comparison runner |
| `package.json` | npm config | SDK harness dependencies |
| `scenarios.json` | Data | Shared scenario definitions |
| `SDK-HARNESS.md` | Documentation | Detailed SDK harness guide |

## 🚀 Quick Start

### Prerequisites

**Required for both:**
- GitHub Copilot CLI installed (`copilot` in PATH)
- GitHub Copilot subscription active

**For CLI harness:**
- PowerShell 7+

**For SDK harness:**
- Node.js >= 18.0.0
- npm (comes with Node.js)

### Installation

```bash
# Install SDK dependencies (first time only)
npm install

# Verify installations
copilot --version
node --version
npm --version
```

## 📊 Running Comparisons

### Option 1: Automated Comparison (Recommended)

Run both harnesses side-by-side automatically:

```powershell
# Compare scenarios 1-5
.\compare-harnesses.ps1 -ScenarioIds "1-5"

# Compare scenarios 1, 3, 7, 10
.\compare-harnesses.ps1 -ScenarioIds "1,3,7,10"

# Compare with specific model
.\compare-harnesses.ps1 -ScenarioIds "1-5" -Model "claude-opus-4.5"

# Run only SDK (skip CLI)
.\compare-harnesses.ps1 -ScenarioIds "1-5" -SkipCLI

# Run only CLI (skip SDK)
.\compare-harnesses.ps1 -ScenarioIds "1-5" -SkipSDK

# Skip analysis report
.\compare-harnesses.ps1 -ScenarioIds "1-5" -NoAnalyze
```

### Option 2: Manual Comparison

Run each harness independently:

```powershell
# Run CLI version
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

# Run SDK version
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1

# Compare metrics manually
# Look at results/run_*_metrics.csv files
```

### Option 3: Full Suite Comparison

Compare all 30 scenarios:

```powershell
# This will take a while (~45 minutes for each harness)
.\compare-harnesses.ps1 -ScenarioIds "1-30" -NoAnalyze

# Then run analysis separately
# (Analyzing CSV files programmatically if desired)
```

## 📈 Understanding Results

After running a comparison, you'll see output like:

```
SCENARIO COMPARISON (sorted by SDK speedup):

Fix_Incorrect_Conservation_Status         CLI:   42.15s → SDK:   35.80s  [1.18x]
  Tool calls: CLI 23 vs SDK 23 (diff:  0)

Rename_Property_Across_Codebase           CLI:  128.40s → SDK:   95.30s  [1.35x]
  Tool calls: CLI 156 vs SDK 156 (diff:  0)

Find_Species_by_Habitat                   CLI:  224.50s → SDK:  231.20s  [0.97x]
  Tool calls: CLI 246 vs SDK 246 (diff:  0)

SUMMARY STATISTICS:
  Avg speedup: 1.12 x
  Max speedup: 1.35 x (SDK faster)
  Min speedup: 0.97 x (SDK slower)
  CLI success rate: 29/30
  SDK success rate: 29/30
```

**Interpreting Results:**
- **Speedup > 1.0**: SDK is faster (better)
- **Speedup < 1.0**: CLI is faster
- **Tool calls diff**: Negative = SDK used fewer tools (better efficiency)
- **Success rate**: Higher is better

## 🔍 Detailed Analysis

### Check Specific Results

```bash
# View latest metrics
cat results/run_*_metrics.csv | tail -20

# Convert to Excel
# (Copy results/run_*_metrics.csv into spreadsheet app)

# Compare specific scenarios
# (Use diff or your favorite comparison tool)
diff results/run_cli_metrics.csv results/run_sdk_metrics.csv
```

### Metric Breakdowns

**Duration (durationSec):**
- Lower = better
- Includes prompt processing, tool execution, response generation

**Tool Calls (totalToolCalls):**
- Lower = more efficient agent behavior
- Identical tool counts indicate both harnesses tracked correctly

**Files Accessed (fileCount):**
- Lower = targeted search vs broad scanning
- Breadcrumb-using scenarios should be lower

**Tokens (estimatedTotalTokens):**
- Lower = less context consumed
- Roughly proportional to latency and cost

**Success Rate:**
- Pass = completed without timeout (300s default)
- Fail = timeout or error

## 🎯 Expected Performance Characteristics

### When SDK Typically Wins
- ✅ Scenarios with many file operations (no text parsing overhead)
- ✅ Streaming-heavy scenarios (native support)
- ✅ High tool call frequency (direct event handling)
- ✅ Large output volumes (JSON-RPC vs text parsing)

### When CLI Might Win
- ✅ Simple prompts (startup overhead minimal)
- ✅ Memory-constrained environments
- ✅ Scenarios with complex tool orchestration

### What Should Be Identical
- 📊 Tool call _counts_ (both detect same tools)
- 📊 Success rates (same scenarios, same rules)
- 📊 Token estimates (both use chars ÷ 4)
- ❌ Exact tool call _detection_ (different parsing methods)

## 🐛 Troubleshooting

### Common Issues

**"copilot not found"**
```bash
# Install Copilot CLI
# https://docs.github.com/en/copilot/how-tos/set-up/install-copilot-cli
```

**"npm ERR! 404"**
```bash
# Clear npm cache and reinstall
rm -r node_modules package-lock.json
npm install
```

**"Cannot find module '@github/copilot-sdk'"**
```bash
# Check Node version (need >= 18)
node --version

# Reinstall packages
npm install --save @github/copilot-sdk
```

**Scenarios timing out**
```powershell
# Increase timeout (default 300s)
.\copilot-harness.ps1 -ScenarioFile scenarios.json -TimeoutSeconds 600
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --timeout 600
```

## 📝 Example Workflow

```powershell
# 1. Run comparison for first 5 scenarios
.\compare-harnesses.ps1 -ScenarioIds "1-5"

# 2. Check the output
dir results/run_*_metrics.csv | tail -2

# 3. Review comparison report
type results/comparison_report.txt

# 4. If SDK is faster, run more scenarios
.\compare-harnesses.ps1 -ScenarioIds "6-15"

# 5. Track results over time
# (Copy metrics to tracking spreadsheet)
```

## 📚 Advanced Usage

### Custom Scenarios

Both harnesses support the same `scenarios.json` format. Add custom scenarios:

```json
{
  "scenarios": [
    {
      "id": 31,
      "name": "My Custom Scenario",
      "category": "Test",
      "prompt": "Your custom prompt here"
    }
  ]
}
```

### Model Comparison

Compare different models:

```powershell
# Run all scenarios with claude-opus-4.5
.\compare-harnesses.ps1 -ScenarioIds "1-5" -Model "claude-opus-4.5"

# Results will include model in metrics
# Compare across models in spreadsheet
```

### Profiling & Optimization

To optimize further:

1. **Identify slow scenarios**: Find ones with low speedup
2. **Profile them**: Run with both harnesses and check tool selection
3. **Optimize prompt**: Refine to use breadcrumbs or targeted searches
4. **Re-measure**: Run scenario again to verify improvement

## 🔗 Related Documentation

- [SDK Harness Details](SDK-HARNESS.md)
- [Scenarios & Categories](scenarios.md)
- [Copilot CLI Installation](https://docs.github.com/en/copilot/how-tos/set-up/install-copilot-cli)
- [Copilot SDK GitHub](https://github.com/github/copilot-sdk)

## 💡 Tips for Fair Comparison

1. **Same environment**: Run on same machine, same network
2. **No other tasks**: Close unnecessary apps
3. **Multiple runs**: Run each scenario 2-3 times, average results
4. **Same model**: Use same AI model for both (not always possible)
5. **Random order**: Alternate CLI/SDK to avoid warm-up bias
6. **Track conditions**: Note OS, CPU, disk speed, network latency

## 📊 Data Export

### For Spreadsheet Analysis

1. Find latest CSV files:
   ```bash
   dir results/run_*_metrics.csv -Recurse
   ```

2. Open in Excel/Google Sheets:
   - CLI results: `results/run_YYYY-MM-DD_HH-MM-SS_metrics.csv`
   - SDK results: `results/run_YYYY-MM-DD_HH-MM-SS_metrics.csv`

3. Create comparison columns:
   - Speedup = CLI Duration ÷ SDK Duration
   - Efficiency = Tool Calls, Files, Tokens

### For Programming/Automation

```powershell
# Load metrics as objects
$cliMetrics = Import-Csv results/run_*_metrics.csv | Where-Object { $_.Model -eq "cli" }
$sdkMetrics = Import-Csv results/run_*_metrics.csv | Where-Object { $_.Model -eq "sdk" }

# Calculate statistics
$cliMetrics | Measure-Object -Property DurationSec -Average
$sdkMetrics | Measure-Object -Property DurationSec -Average
```

## 🎓 Learning Outcomes

After this comparison, you'll understand:
- ✅ Architecture differences (CLI spawning vs SDK integration)
- ✅ Parsing approaches (text regex vs structured events)
- ✅ Performance tradeoffs (latency, throughput, resource usage)
- ✅ Tool detection methods and accuracy
- ✅ Which implementation suits your use case

## 🍎 Next Steps

1. **Run baseline**: `.\compare-harnesses.ps1 -ScenarioIds "1-10"`
2. **Analyze results**: Review metrics and comparison report
3. **Identify patterns**: Which scenarios benefit from SDK?
4. **Optimize prompts**: Use findings to improve prompt design
5. **Scale testing**: Run full suite if patterns are clear
6. **Document findings**: Share results with team

## 📧 Feedback

Found issues? Have improvement ideas?
- Check [Copilot SDK Issues](https://github.com/github/copilot-sdk/issues)
- Review [scenarios.md](scenarios.md) for scenario improvements
- Update this guide for your findings

---

**Happy benchmarking! 🚀**
