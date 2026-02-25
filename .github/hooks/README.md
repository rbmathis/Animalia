# Breadcrumb Maintenance Hooks

This directory contains **Agent Hooks** that automatically maintain breadcrumb metadata as code evolves.

> 📖 **See** [`../../breadcrumbs_lifecycle.md`](../../breadcrumbs_lifecycle.md) for the complete lifecycle documentation.

---

## What Hooks Do

Hooks are deterministic scripts that execute at key points during an agent session. These hooks specifically:

1. **Detect** when breadcrumb-related files are modified
2. **Trigger** breadcrumb refresh for affected taxonomy levels
3. **Cascade** updates up the hierarchy (Species → Genus → Family → Order)
4. **Report** changes to the agent and user

---

## Files in This Directory

| File | Purpose |
|------|---------|
| `breadcrumb-maintenance.json` | Hook configuration (loaded by VS Code) |
| `breadcrumb-post-tool.py` | Runs after agent edits files (PostToolUse event) |
| `breadcrumb-stop.py` | Runs when agent session ends (Stop event) |

---

## Quick Start

### 1. Enable Hooks in VS Code

Hooks are automatically discovered from `.github/hooks/*.json` by VS Code's Copilot Chat.

To verify hooks are loaded:
1. Open VS Code Chat
2. Right-click in Chat view → **Diagnostics**
3. Look for "Hooks" section
4. Should see: `PostToolUse`, `Stop` hooks loaded

### 2. Test a Hook Manually

In a terminal:
```bash
# Simulate PostToolUse hook input
python .github/hooks/breadcrumb-post-tool.py <<EOF
{
  "timestamp": "2026-02-24T10:30:00.000Z",
  "cwd": ".",
  "sessionId": "test-session",
  "hookEventName": "PostToolUse",
  "tool_name": "editFiles",
  "tool_input": {},
  "tool_response": "File edited: root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/Canis_lupus.cs",
  "tool_use_id": "tool-123"
}
EOF
```

Expected output:
```json
{
  "continue": true,
  "hookSpecificOutput": {
    "additionalContext": "Breadcrumb maintenance: 1 file(s) modified. Scheduling refresh for 3 breadcrumb(s)."
  }
}
```

### 3. View Hook Execution

In VS Code:
1. Open **Output** panel (View → Output)
2. Select **GitHub Copilot Chat Hooks** from dropdown
3. Run agent commands and watch hook output

---

## Hook Details

### PostToolUse: `breadcrumb-post-tool.py`

**When it runs:** After agent uses any tool (typically `editFiles`, `runCommand`)

**What it does:**
1. Extracts modified file paths from tool response
2. Checks if files are species (\_\_), interfaces (I), or breadcrumb files
3. Maps files to affected taxonomy levels
4. Triggers selective breadcrumb refresh

**Example:**
```
Agent modifies: Canis_lupus.cs
Hook detects: Species file in Canis/
Hook triggers: Refresh Canis/breadcrumb.md
```

**Timeout:** 60 seconds

---

### Stop: `breadcrumb-stop.py`

**When it runs:** When agent session ends

**What it does:**
1. Reads full session transcript
2. Analyzes all tool invocations
3. Identifies all breadcrumb-affected files
4. Calculates cascade updates needed
5. Generates summary report

**Example output:**
```
---
Breadcrumb Maintenance Summary
Session: session-abc123
---

Files Modified: 3
  • root/.../Canis_lupus.cs
  • root/.../Canis_latrans.cs
  • root/.../ICanis.cs

Breadcrumbs Affected: 3
  • Canis/breadcrumb.md
  • Canidae/breadcrumb.md
  • Carnivora/breadcrumb.md

Status: ✅ Breadcrumb sync complete.
```

**Timeout:** 120 seconds

---

## Configuration

### Hook File Format

See `breadcrumb-maintenance.json`:

```json
{
  "hooks": {
    "PostToolUse": [
      {
        "type": "command",
        "command": "python .github/hooks/breadcrumb-post-tool.py",
        "windows": "python .github\\hooks\\breadcrumb-post-tool.py",
        "timeout": 60,
        "env": {
          "HOOK_EVENT": "PostToolUse"
        }
      }
    ],
    "Stop": [...]
  }
}
```

**Key properties:**
- `type`: Always `"command"`
- `command`: Default command (Linux/macOS)
- `windows`: Windows-specific override
- `timeout`: Max seconds to wait (default: 30)
- `env`: Environment variables passed to script
- `cwd`: Working directory

### Hook Discovery

VS Code searches for hooks in this order (workspace first):
1. `.github/hooks/*.json` ← **We use this**
2. `.claude/settings.json`
3. `~/.claude/settings.json`

---

## Troubleshooting

### Hooks Not Firing

**Check 1: Configuration file exists**
```bash
ls .github/hooks/breadcrumb-maintenance.json
```

**Check 2: Hooks are loaded**
- Chat → Right-click → Diagnostics
- Look for hook entries in output

**Check 3: Hook script has execute permissions**
```bash
chmod +x .github/hooks/breadcrumb-post-tool.py
chmod +x .github/hooks/breadcrumb-stop.py
```

### Hook Errors

**View hook output:**
1. Open VS Code Output panel
2. Select **GitHub Copilot Chat Hooks** channel
3. Look for error messages

**Common issues:**
- `Permission denied`: Run `chmod +x` on scripts
- `ModuleNotFoundError`: Missing Python dependencies (use only stdlib)
- `Timeout`: Hook took >60s, increase timeout value or optimize script

### Testing Hooks Locally

```bash
# Test PostToolUse
echo '{...}' | python .github/hooks/breadcrumb-post-tool.py

# Test Stop
echo '{...}' | python .github/hooks/breadcrumb-stop.py
```

---

## Hook Lifecycle Events (Reference)

For complete hook documentation, see:
[VS Code Agent Hooks](https://code.visualstudio.com/docs/copilot/customization/hooks)

**Events relevant to breadcrumbs:**

| Event | When | We Use For |
|-------|------|-----------|
| `SessionStart` | Agent session begins | (Not used) |
| `PreToolUse` | Before tool executes | (Not used) |
| `PostToolUse` | After tool succeeds | ✅ Detect changes |
| `Stop` | Session ends | ✅ Final sync |
| `PreCompact` | Context compacts | (Not used) |
| `UserPromptSubmit` | User submits prompt | (Not used) |
| `SubagentStart/Stop` | Subagent lifecycle | (Not used) |

---

## Next Steps

1. **Enable hooks**: Test in VS Code Chat by running agent commands
2. **Monitor**: Watch Output panel for hook execution
3. **Iterate**: Refine scripts based on hook output
4. **Document**: Add custom tags/metadata to `breadcrumb-maintenance.json`
5. **Scale**: Consider adding hooks for other metadata patterns

---

## Related Documentation

- [Breadcrumbs Lifecycle](../../breadcrumbs_lifecycle.md)
- [Breadcrumb Schema](../../architecture.md)
- [Pet Lookup Skill](../skills/pet-lookup/SKILL.md)
- [VS Code Hooks Reference](https://code.visualstudio.com/docs/copilot/customization/hooks)
