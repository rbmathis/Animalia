# Quick Start: Copilot CLI vs SDK Comparison

## ✅ Setup Complete

You now have **two harness implementations** for comparing Copilot performance:

### PowerShell CLI Harness (existing)
```bash
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1
```

### Node.js/ESM SDK Harness (new)
```bash
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1
```

## 🚀 Run a Quick Comparison

### Option 1: Test Both on Same Scenario (Recommended)

```bash
# Test CLI version
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

# Test SDK version (wait for CLI to finish)
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1

# Compare results (both go to results/ directory)
# Look for latest run_*_metrics.csv files
```

### Option 2: Automated Comparison Script

```powershell
.\compare-harnesses.ps1 -ScenarioIds "1,3,5" -NoAnalyze
```

## 📊 What Gets Measured

Both harnesses collect **identical metrics**:
- **Duration** (seconds)
- **Success** (pass/fail)
- **Tool Calls** (read_file, grep_search, etc.)
- **Files Accessed** (count + list)
- **Breadcrumb Usage** (yes/no)
- **Token Estimates** (input + output)
- **Resource Usage** (CPU, memory)

## 📁 Output Files

After running, check `results/` for:
- `run_*_metrics.json` - Full metrics in JSON (detailed)
- `run_*_metrics.csv` - Metrics in CSV (easy to compare)
- `run_*_output.txt` - Scenario outputs and logs

## 🔧 Troubleshooting

### SDK Harness Errors

**"Cannot read properties of undefined"**
- ✅ Fixed! Updated harness to handle scenarios.json array format

**"Copilot SDK not available"**
- Check: `npm list @github/copilot-sdk`
- Install: `npm install @github/copilot-sdk`

### CLI Harness Issues
- See [SDK-HARNESS.md](SDK-HARNESS.md) for detailed troubleshooting

## 📈 Performance Tips

1. **Run in isolation** - Close other apps to reduce noise
2. **Run multiple times** - Average results for fairness
3. **Test same scenarios** - Compare identical prompts
4. **Check resource stats** - Look for CPU/memory differences

## 📚 More Information

- [COMPARISON-GUIDE.md](COMPARISON-GUIDE.md) - Detailed workflows
- [SDK-HARNESS.md](SDK-HARNESS.md) - Technical details
- [scenarios.md](scenarios.md) - Test scenario descriptions

## ⚙️ Available Commands

### SDK Harness
```bash
# Run scenario 1
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1

# Run scenarios 1-5
for ($i = 1; $i -le 5; $i++) {
  node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id $i
}

# With specific model
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --model claude-opus-4.5

# Dry run (no execution)
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --dry-run

# Custom output directory
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --output-dir ./my-results
```

### PowerShell CLI Harness
```bash
# Run scenario 1
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1

# Run with model
.\copilot-harness.ps1 -ScenarioFile scenarios.json -Model "claude-opus-4.5"

# Run all scenarios
.\copilot-harness.ps1 -ScenarioFile scenarios.json

# Dry run
.\copilot-harness.ps1 -ScenarioFile scenarios.json -DryRun
```

## 📊 Expected Results

**SDK typically faster on:**
- Long-running scenarios (JSON-RPC overhead is one-time)
- High tool-call volume (no text parsing needed)
- Large outputs (streaming advantage)

**CLI might match or excel on:**
- Simple prompts (comparable overhead)
- Short-duration scenarios (fixed costs matter less)
- Complex tool orchestration (depends on implementation)

## ✨ Key Files

| File | Purpose |
|------|---------|
| `copilot-harness-sdk-esm.mjs` | SDK harness (Node.js/ESM) |
| `copilot-harness.ps1` | CLI harness (PowerShell) |
| `compare-harnesses.ps1` | Automated comparison runner |
| `scenarios.json` | Shared scenario definitions |
| `results/` | Output metrics and logs |

---

**Ready to compare?** Start with a single scenario test:

```bash
.\copilot-harness.ps1 -ScenarioFile scenarios.json -ScenarioId 1
node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1
```

Then compare the CSV files in `results/`! 🚀
