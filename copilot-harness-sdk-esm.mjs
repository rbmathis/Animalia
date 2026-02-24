#!/usr/bin/env node
/**
 * Copilot SDK Harness - ESM Version
 * Performance comparison harness using GitHub Copilot SDK instead of CLI.
 * Measures same metrics as PowerShell CLI version for fair comparison.
 *
 * Usage:
 *   node copilot-harness-sdk-esm.mjs --prompt "Your prompt"
 *   node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json
 *   node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1
 */

import fs from "fs";
import path from "path";
import { performance } from "perf_hooks";
import { fileURLToPath } from "url";

// Import Copilot SDK
let CopilotClient;
try {
  const sdk = await import("@github/copilot-sdk");
  CopilotClient = sdk.CopilotClient;
} catch (err) {
  console.error("✗ Error: Copilot SDK not available");
  console.error(`  Details: ${err.message}`);
  console.error("  Install with: npm install @github/copilot-sdk");
  console.error("");
  console.error("Note: The Copilot SDK requires GitHub Copilot CLI to be installed.");
  console.error("Visit: https://docs.github.com/en/copilot/how-tos/copilot-cli/cli-getting-started");
  process.exit(1);
}

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// ============================================================================
// CONFIGURATION
// ============================================================================

const TOOL_KEYWORDS = {
  read_file: ["read_file", "reading file", "read from"],
  grep_search: ["grep_search", "searching for", "grep"],
  semantic_search: ["semantic_search", "semantic"],
  file_search: ["file_search", "finding files", "glob"],
  list_dir: ["list_dir", "listing directory"],
  create_file: ["create_file", "creating file"],
  replace_string: ["replace_string", "editing file", "replace"],
  run_terminal: ["run_terminal", "running command", "execute"],
};

// ============================================================================
// HELPER FUNCTIONS
// ============================================================================

function log(level, message) {
  const timestamp = new Date().toISOString();
  const prefix = `[${timestamp}] [${level.toUpperCase()}]`;
  console.log(`${prefix} ${message}`);
}

function getTimestamp() {
  return new Date()
    .toISOString()
    .replace(/[:.]/g, "-")
    .slice(0, -5);
}

function estimateTokens(text) {
  // Rough estimate: ~4 chars per token
  return Math.ceil(text.length / 4);
}

function newResultsDir(dirPath) {
  if (!fs.existsSync(dirPath)) {
    fs.mkdirSync(dirPath, { recursive: true });
  }
  return path.resolve(dirPath);
}

// Normalize tool names from various SDK event formats to our standard names
function normalizeToolName(toolName) {
  if (!toolName) return null;
  const name = toolName.toLowerCase().replace(/[_-]/g, "");

  const mapping = {
    // Read file variants
    "readfile": "read_file",
    "read_file": "read_file",
    "view": "read_file",

    // Grep search variants
    "grepsearch": "grep_search",
    "grep_search": "grep_search",
    "grep": "grep_search",

    // Semantic search variants
    "semanticsearch": "semantic_search",
    "semantic_search": "semantic_search",

    // File search variants
    "filesearch": "file_search",
    "file_search": "file_search",
    "globsearch": "file_search",
    "glob": "file_search",

    // List directory variants
    "listdir": "list_dir",
    "list_dir": "list_dir",
    "listdirectory": "list_dir",
    "ls": "list_dir",

    // Create file variants
    "createfile": "create_file",
    "create_file": "create_file",
    "write": "create_file",

    // Replace string variants
    "replacestring": "replace_string",
    "replace_string": "replace_string",
    "replacestringinfile": "replace_string",
    "replace_string_in_file": "replace_string",
    "edit": "replace_string",

    // Run terminal variants
    "runterminal": "run_terminal",
    "run_terminal": "run_terminal",
    "runinterminal": "run_terminal",
    "run_in_terminal": "run_terminal",
    "powershell": "run_terminal",
    "bash": "run_terminal",
    "shell": "run_terminal",
    "terminal": "run_terminal",
  };

  return mapping[name] || mapping[toolName.toLowerCase()] || null;
}

function parseToolCalls(output) {
  const toolCounts = {
    read_file: 0,
    grep_search: 0,
    semantic_search: 0,
    file_search: 0,
    list_dir: 0,
    create_file: 0,
    replace_string: 0,
    run_terminal: 0,
  };

  for (const [tool, keywords] of Object.entries(TOOL_KEYWORDS)) {
    for (const keyword of keywords) {
      const regex = new RegExp(keyword, "gi");
      const matches = output.match(regex) || [];
      toolCounts[tool] = (toolCounts[tool] || 0) + matches.length;
    }
  }

  return toolCounts;
}

function parseFilesAccessed(output) {
  const files = new Set();

  // Match file paths in various formats
  const patterns = [
    /(?:read_file|Reading|Editing|Creating).*?["`]([^"`]+\.[a-z]+)["`]/gi,
    /(?:read from|opened|wrote to)\s+([^\s\n]+\.[a-z]+)/gi,
    /File:\s+([^\n]+\.[a-z]+)/gi,
  ];

  for (const pattern of patterns) {
    let match;
    while ((match = pattern.exec(output)) !== null) {
      if (match[1]) {
        files.add(match[1]);
      }
    }
  }

  return Array.from(files);
}

function getResourceStats() {
  const memUsage = process.memoryUsage();
  const cpuUsage = process.cpuUsage();

  return {
    sampleCount: 1,
    cpuAvg: cpuUsage.user / 1000,
    cpuMax: cpuUsage.user / 1000,
    memAvgMB: Math.round((memUsage.heapUsed / 1024 / 1024) * 100) / 100,
    memMaxMB: Math.round((memUsage.heapTotal / 1024 / 1024) * 100) / 100,
    procReadMB: 0,
    procWriteMB: 0,
    sysReadMB: 0,
    sysWriteMB: 0,
  };
}

async function loadScenarios(filePath) {
  if (!fs.existsSync(filePath)) {
    throw new Error(`Scenario file not found: ${filePath}`);
  }
  const content = fs.readFileSync(filePath, "utf-8");
  const data = JSON.parse(content);
  // Handle both { scenarios: [...] } and direct [...] formats
  return Array.isArray(data) ? data : data.scenarios || [];
}

// ============================================================================
// COPILOT SDK HARNESS
// ============================================================================

class CopilotHarness {
  constructor(outputDir = "./results", model = null, timeoutSeconds = 300, enableTelemetry = true) {
    this.outputDir = newResultsDir(outputDir);
    this.model = model;
    this.timeoutSeconds = timeoutSeconds;
    this.enableTelemetry = enableTelemetry;
    this.client = null;
    this.session = null;
  }

  async start() {
    try {
      log("info", "Starting Copilot SDK client...");
      this.client = new CopilotClient({
        autoStart: true,
        autoRestart: true,
      });
      await this.client.start();
      log("info", "✓ Copilot SDK client started");

      // Create a single session for all scenarios
      log("info", "Creating persistent session for all scenarios...");
      this.session = await this.client.createSession({
        model: this.model,
      });
      log("info", "✓ Session created");
    } catch (err) {
      log("error", `Failed to start Copilot SDK: ${err.message}`);
      throw err;
    }
  }

  async stop() {
    try {
      // Destroy session if it exists
      if (this.session) {
        try {
          log("info", "Destroying session...");
          await this.session.destroy();
          this.session = null;
          log("info", "✓ Session destroyed");
        } catch (err) {
          log("warn", `Error destroying session: ${err.message}`);
        }
      }

      // Stop client
      if (this.client) {
        log("info", "Stopping Copilot SDK client...");
        await this.client.stop();
        log("info", "✓ Copilot SDK client stopped");
      }
    } catch (err) {
      log("warn", `Error stopping client: ${err.message}`);
    }
  }

  async runPrompt(prompt, timeoutMs = null) {
    const startTime = performance.now();
    const allOutput = [];
    let success = false;
    let error = "";

    // Track tool calls from events directly
    const eventToolCalls = {
      read_file: 0,
      grep_search: 0,
      semantic_search: 0,
      file_search: 0,
      list_dir: 0,
      create_file: 0,
      replace_string: 0,
      run_terminal: 0,
    };
    const eventFilesAccessed = new Set();

    try {
      if (!this.client || !this.session) {
        throw new Error("Client or session not initialized. Call start() first.");
      }

      let outputContent = "";

      // Subscribe to events for this specific message
      const handleMessage = (event) => {
        const eventType = event.type || "unknown";
        if (eventType === "assistant.message") {
          const content = event.data?.content || "";
          outputContent += content;
          allOutput.push(content);
        }
      };

      // Handle tool execution events
      const handleToolStart = (event) => {
        const toolName = event.data?.toolName || event.data?.name || event.name || "";
        const normalizedName = normalizeToolName(toolName);
        if (normalizedName && eventToolCalls.hasOwnProperty(normalizedName)) {
          eventToolCalls[normalizedName]++;
        }
        // Log tool execution for visibility
        const args = event.data?.arguments || event.data?.args || {};
        log("debug", `  ⚙️ Tool: ${toolName}`);

        // Track file access from tool arguments
        if (args.filePath || args.path) {
          eventFilesAccessed.add(args.filePath || args.path);
        }
        if (args.query && (normalizedName === "file_search" || normalizedName === "grep_search")) {
          allOutput.push(`● ${toolName}: ${args.query}`);
        }
      };

      const handleToolEnd = (event) => {
        // Capture tool output if available
        const result = event.data?.result || event.data?.output || "";
        if (result && typeof result === "string") {
          allOutput.push(result);
        }
      };

      // Catch-all for debugging - log ALL events to understand SDK event structure
      const handleAnyEvent = (event) => {
        const eventType = event.type || event.name || "unknown";
        // Only log tool-related events we haven't handled
        if (eventType.includes("tool") || eventType.includes("function")) {
          log("debug", `  📡 Event: ${eventType}`);
        }
      };

      const handleIdle = () => {
        // Will be resolved by the promise below
      };

      // Register all event handlers
      this.session.on("assistant.message", handleMessage);
      this.session.on("session.idle", handleIdle);

      // Tool execution events - only register if telemetry is enabled
      if (this.enableTelemetry) {
        this.session.on("tool.start", handleToolStart);
        this.session.on("tool.end", handleToolEnd);
        this.session.on("tool.execution_start", handleToolStart);
        this.session.on("tool.execution_complete", handleToolEnd);
        this.session.on("tool_call", handleToolStart);
        this.session.on("function_call", handleToolStart);

        // Debug: catch all events
        this.session.on("*", handleAnyEvent);
      }

      // Send prompt with timeout
      const done = new Promise((resolve, reject) => {
        const timeout = setTimeout(() => {
          // Clean up all event listeners on timeout
          cleanupListeners();
          reject(new Error(`TIMEOUT after ${this.timeoutSeconds}s`));
        }, (timeoutMs || this.timeoutSeconds * 1000));

        const idleHandler = () => {
          clearTimeout(timeout);
          cleanupListeners();
          resolve();
        };

        this.session.on("session.idle", idleHandler);
      });

      // Helper to clean up all listeners
      const cleanupListeners = () => {
        try {
          this.session.removeEventListener?.("assistant.message", handleMessage);
          this.session.removeEventListener?.("session.idle", handleIdle);
          if (this.enableTelemetry) {
            this.session.removeEventListener?.("tool.start", handleToolStart);
            this.session.removeEventListener?.("tool.end", handleToolEnd);
            this.session.removeEventListener?.("tool.execution_start", handleToolStart);
            this.session.removeEventListener?.("tool.execution_complete", handleToolEnd);
            this.session.removeEventListener?.("tool_call", handleToolStart);
            this.session.removeEventListener?.("function_call", handleToolStart);
            this.session.removeEventListener?.("*", handleAnyEvent);
          }
        } catch {}
      };

      await this.session.send({ prompt });
      await done;
      success = true;
    } catch (err) {
      error = err.message || String(err);
      success = false;
      // Try to clean up event listeners on error
      try {
        if (this.session) {
          this.session.removeAllListeners?.();
        }
      } catch {}
    }

    const endTime = performance.now();
    const durationMs = endTime - startTime;
    const fullOutput = allOutput.join("\n");

    // Tool and file tracking - only when telemetry is enabled
    let toolCalls = {
      read_file: 0,
      grep_search: 0,
      semantic_search: 0,
      file_search: 0,
      list_dir: 0,
      create_file: 0,
      replace_string: 0,
      run_terminal: 0,
    };
    let filesAccessed = [];
    let breadcrumbsUsed = false;

    if (this.enableTelemetry) {
      // Get tool calls from text parsing (fallback)
      const textToolCalls = parseToolCalls(fullOutput);

      // Merge event-based tool calls with text-based (prefer events, fallback to text)
      for (const key of Object.keys(eventToolCalls)) {
        // Use event count if > 0, otherwise use text parsing count
        toolCalls[key] = eventToolCalls[key] > 0 ? eventToolCalls[key] : textToolCalls[key];
      }

      // Get files accessed - merge event-tracked files with text-parsed
      const textFilesAccessed = parseFilesAccessed(fullOutput);
      filesAccessed = [...new Set([...eventFilesAccessed, ...textFilesAccessed])];

      breadcrumbsUsed = filesAccessed.some((f) =>
        f.toLowerCase().includes("breadcrumb")
      );
    }

    return {
      scenario: "prompt",
      timestamp: getTimestamp(),
      model: this.model,
      prompt,
      durationMs: Math.round(durationMs),
      durationSec: Math.round((durationMs / 1000) * 100) / 100,
      exitCode: success ? 0 : 1,
      success,
      toolCalls,
      totalToolCalls: Object.values(toolCalls).reduce((a, b) => a + b, 0),
      filesAccessed,
      fileCount: filesAccessed.length,
      usedBreadcrumbs: breadcrumbsUsed,
      estimatedInputTokens: estimateTokens(prompt),
      estimatedOutputTokens: estimateTokens(fullOutput),
      estimatedTotalTokens:
        estimateTokens(prompt) + estimateTokens(fullOutput),
      resources: getResourceStats(),
      error,
    };
  }

  async runScenario(scenario) {
    log("info", `Starting scenario ${scenario.id}: ${scenario.name}`);
    log("info", `Prompt: ${scenario.prompt}`);

    const result = await this.runPrompt(scenario.prompt);
    result.scenario = `scenario_${scenario.id}_${scenario.name}`;

    if (result.success) {
      log("info", `✓ Scenario ${scenario.id} completed in ${result.durationSec}s`);
    } else {
      log("warn", `✗ Scenario ${scenario.id} failed: ${result.error}`);
    }

    return result;
  }

  async exportResults(results, runTimestamp) {
    if (results.length === 0) {
      return;
    }

    // Export consolidated output (prefix with 'sdk_' to distinguish from CLI harness)
    const outputFile = path.join(
      this.outputDir,
      `sdk_run_${runTimestamp}_output.txt`
    );
    const outputLines = [];
    for (const result of results) {
      outputLines.push(
        `===============================================================================`
      );
      outputLines.push(`=== ${result.scenario}`);
      outputLines.push(
        `===============================================================================`
      );
      outputLines.push(`Duration: ${result.durationSec}s`);
      outputLines.push(`Success: ${result.success}`);
      outputLines.push(`Tool Calls: ${result.totalToolCalls}`);
      outputLines.push(`Files Accessed: ${result.fileCount}`);
      if (result.error) {
        outputLines.push(`Error: ${result.error}`);
      }
      outputLines.push("");
    }
    fs.writeFileSync(outputFile, outputLines.join("\n"), "utf-8");
    log("info", `✓ Output: ${outputFile}`);

    // Export metrics as JSON
    const metricsFile = path.join(
      this.outputDir,
      `sdk_run_${runTimestamp}_metrics.json`
    );
    const metrics = {
      runTimestamp,
      scenarioCount: results.length,
      totalDurationSec:
        Math.round(
          (results.reduce((sum, r) => sum + r.durationMs, 0) / 1000) * 100
        ) / 100,
      successCount: results.filter((r) => r.success).length,
      scenarios: results,
    };
    fs.writeFileSync(metricsFile, JSON.stringify(metrics, null, 2), "utf-8");
    log("info", `✓ Metrics: ${metricsFile}`);

    // Export as CSV
    const csvFile = path.join(this.outputDir, `sdk_run_${runTimestamp}_metrics.csv`);
    const csvLines = [
      [
        "Scenario",
        "Model",
        "DurationSec",
        "Success",
        "UsedBreadcrumbs",
        "TotalToolCalls",
        "ReadFileCalls",
        "GrepSearchCalls",
        "FileCount",
        "EstimatedTokens",
        "CpuAvg",
        "MemAvgMB",
      ].join(","),
    ];

    for (const result of results) {
      csvLines.push(
        [
          result.scenario,
          result.model || "",
          result.durationSec,
          result.success ? "true" : "false",
          result.usedBreadcrumbs ? "true" : "false",
          result.totalToolCalls,
          result.toolCalls.read_file,
          result.toolCalls.grep_search,
          result.fileCount,
          result.estimatedTotalTokens,
          result.resources.cpuAvg,
          result.resources.memAvgMB,
        ].join(",")
      );
    }

    fs.writeFileSync(csvFile, csvLines.join("\n"), "utf-8");
    log("info", `✓ CSV: ${csvFile}`);
  }
}

// ============================================================================
// MAIN
// ============================================================================

async function main() {
  let prompt;
  let scenarioFile;
  let scenarioId;
  let model;
  let outputDir = "./results";
  let dryRun = false;
  let enableTelemetry = true;

  // Parse arguments
  const args = process.argv.slice(2);
  for (let i = 0; i < args.length; i++) {
    const arg = args[i];
    if (arg === "--prompt" && args[i + 1]) {
      prompt = args[++i];
    } else if (arg === "--scenario-file" && args[i + 1]) {
      scenarioFile = args[++i];
    } else if (arg === "--scenario-id" && args[i + 1]) {
      scenarioId = parseInt(args[++i], 10);
    } else if (arg === "--model" && args[i + 1]) {
      model = args[++i];
    } else if (arg === "--output-dir" && args[i + 1]) {
      outputDir = args[++i];
    } else if (arg === "--dry-run") {
      dryRun = true;
    } else if (arg === "--no-telemetry") {
      enableTelemetry = false;
    }
  }

  console.log("");
  console.log(
    "╔═══════════════════════════════════════════════════════════════╗"
  );
  console.log(
    "║          COPILOT SDK HARNESS (Node.js/ESM)                   ║"
  );
  console.log(
    "║          Telemetry & Benchmarking Tool                        ║"
  );
  console.log(
    "╚═══════════════════════════════════════════════════════════════╝"
  );
  console.log("");

  if (!prompt && !scenarioFile) {
    console.log("Usage:");
    console.log(
      "  node copilot-harness-sdk-esm.mjs --prompt 'Your prompt here'"
    );
    console.log(
      "  node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json"
    );
    console.log(
      "  node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --scenario-id 1"
    );
    console.log(
      "  node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --model 'claude-opus-4.5'"
    );
    console.log(
      "  node copilot-harness-sdk-esm.mjs --scenario-file scenarios.json --no-telemetry"
    );
    console.log("");
    process.exit(0);
  }

  if (!enableTelemetry) {
    log("info", "Tool/file telemetry DISABLED (--no-telemetry)");
  }

  const harness = new CopilotHarness(outputDir, model, 300, enableTelemetry);
  const runTimestamp = getTimestamp();
  const allResults = [];

  try {
    if (!dryRun) {
      await harness.start();
    }

    if (prompt) {
      log("info", "Running single prompt...");
      if (dryRun) {
        log("info", `[DRY RUN] Would execute: ${prompt}`);
      } else {
        const result = await harness.runPrompt(prompt);
        allResults.push(result);
      }
    } else if (scenarioFile) {
      const scenarios = await loadScenarios(scenarioFile);
      log("info", `Loaded ${scenarios.length} scenarios from ${scenarioFile}`);

      for (const scenario of scenarios) {
        if (scenarioId && scenario.id !== scenarioId) {
          continue;
        }

        log("info", "━".repeat(70));
        if (dryRun) {
          log("info", `[DRY RUN] Would run scenario ${scenario.id}`);
        } else {
          const result = await harness.runScenario(scenario);
          allResults.push(result);
        }
      }
    }

    if (!dryRun && allResults.length > 0) {
      await harness.exportResults(allResults, runTimestamp);

      console.log("");
      console.log(
        "═══════════════════════════════════════════════════════════════"
      );
      console.log(`✓ COMPLETE: ${allResults.length} scenario(s) executed`);
      console.log(
        "═══════════════════════════════════════════════════════════════"
      );
    }
  } catch (err) {
    log("error", `Fatal error: ${err.message}`);
    process.exit(1);
  } finally {
    if (!dryRun) {
      await harness.stop();
    }
  }
}

main().catch((err) => {
  console.error("Fatal error:", err);
  process.exit(1);
});
