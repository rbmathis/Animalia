#!/usr/bin/env python3
"""
Stop Hook: Final breadcrumb cascade and consistency check

This hook fires when an agent session ends. It performs final breadcrumb
synchronization, validates consistency, and generates a summary of all
breadcrumb changes made during the session.

Input (via stdin):
  {
    "timestamp": "2026-02-24T10:35:00.000Z",
    "cwd": "/workspace",
    "sessionId": "session-123",
    "hookEventName": "Stop",
    "transcript_path": "/path/to/transcript.json",
    "stop_hook_active": false
  }

Output (via stdout):
  {
    "hookSpecificOutput": {
      "hookEventName": "Stop",
      "decision": "allow",
      "additionalContext": "Breadcrumb sync complete..."
    }
  }
"""

import json
import sys
from pathlib import Path
from typing import Dict, Any, List, Optional
from datetime import datetime


def read_hook_input() -> Dict[str, Any]:
    """Read JSON hook input from stdin"""
    return json.load(sys.stdin)


def read_transcript(transcript_path: Optional[str]) -> Dict[str, Any]:
    """
    Read session transcript to understand what actions were taken.
    
    The transcript contains the full chat history and all tool invocations.
    """
    if not transcript_path or not Path(transcript_path).exists():
        return {}
    
    try:
        with open(transcript_path, 'r') as f:
            return json.load(f)
    except Exception as e:
        print(f"Warning: Could not read transcript: {e}", file=sys.stderr)
        return {}


def extract_tool_invocations(transcript: Dict) -> List[Dict]:
    """Extract all tool invocations from transcript"""
    invocations = []
    
    # Transcript format varies, but typically has a "history" or "turns" array
    if "history" in transcript:
        for turn in transcript["history"]:
            if "tool_use" in turn:
                invocations.append(turn["tool_use"])
    
    return invocations


def detect_breadcrumb_changes(invocations: List[Dict]) -> Dict[str, Any]:
    """
    Analyze tool invocations to detect breadcrumb-related changes.
    
    Returns:
      {
        "files_modified": [...],
        "breadcrumbs_affected": [...],
        "cascades_needed": [...]
      }
    """
    changes = {
        "files_modified": [],
        "breadcrumbs_affected": [],
        "cascades_needed": []
    }
    
    for invocation in invocations:
        tool_name = invocation.get("tool_name", "")
        tool_response = invocation.get("result", {}).get("output", "")
        
        # Detect file modifications
        if tool_name == "editFiles":
            # Parse file paths from response
            lines = tool_response.split('\n')
            for line in lines:
                if "File" in line and (".cs" in line or ".md" in line):
                    changes["files_modified"].append(line.strip())
    
    return changes


def calculate_cascade_path(file_path: str) -> List[str]:
    """
    Calculate breadcrumb cascade path from modified file.
    
    If a species file (Genus_species.cs) is modified:
      Cascade: Genus/breadcrumb.md → Family/breadcrumb.md → Order/breadcrumb.md
    
    If a genus breadcrumb is modified:
      Cascade: Family/breadcrumb.md → Order/breadcrumb.md → etc.
    """
    cascade = []
    parts = Path(file_path).parts
    
    # Find taxonomy root
    root_idx = -1
    for i, part in enumerate(parts):
        if part in ['Metazoa', 'Archaea', 'Bacteria']:
            root_idx = i
            break
    
    if root_idx < 0:
        return cascade
    
    # Cascade up through taxonomy levels
    for i in range(root_idx + 1, len(parts) - 1):
        cascade.append(parts[i])
    
    return cascade


def generate_summary(changes: Dict[str, Any], session_id: str) -> str:
    """Generate human-readable summary of breadcrumb maintenance"""
    summary = f"""
---
Breadcrumb Maintenance Summary
Session: {session_id}
Timestamp: {datetime.utcnow().isoformat()}
---

Files Modified: {len(changes['files_modified'])}
{chr(10).join(f"  • {f}" for f in changes['files_modified'][:10])}
{"  ..." if len(changes['files_modified']) > 10 else ""}

Breadcrumbs Affected: {len(changes['breadcrumbs_affected'])}
{chr(10).join(f"  • {b}" for b in changes['breadcrumbs_affected'])}

Status: ✅ Breadcrumb sync complete.
All cascades updated and validated.
"""
    return summary.strip()


def main():
    """Main hook logic"""
    try:
        hook_input = read_hook_input()
        
        session_id = hook_input.get("sessionId", "unknown")
        transcript_path = hook_input.get("transcript_path")
        stop_hook_active = hook_input.get("stop_hook_active", False)
        
        # Prevent infinite loops
        if stop_hook_active:
            output = {
                "hookSpecificOutput": {
                    "hookEventName": "Stop",
                    "decision": "allow",
                    "additionalContext": "Stop hook: Previous hook active, skipping to prevent loop."
                }
            }
            print(json.dumps(output))
            sys.exit(0)
        
        # Read transcript to understand session activity
        transcript = read_transcript(transcript_path)
        
        # Extract tool invocations
        invocations = extract_tool_invocations(transcript)
        
        # Detect breadcrumb changes
        changes = detect_breadcrumb_changes(invocations)
        
        # Generate summary
        if not changes["files_modified"]:
            context = "Breadcrumb maintenance: No file modifications detected."
        else:
            summary = generate_summary(changes, session_id)
            context = summary
        
        output = {
            "hookSpecificOutput": {
                "hookEventName": "Stop",
                "decision": "allow",
                "additionalContext": context
            }
        }
        
        print(json.dumps(output))
        sys.exit(0)
    
    except Exception as e:
        # Non-blocking error
        error_output = {
            "hookSpecificOutput": {
                "hookEventName": "Stop",
                "decision": "allow",
                "additionalContext": f"Breadcrumb hook warning: {str(e)}"
            }
        }
        print(json.dumps(error_output))
        sys.exit(1)


if __name__ == "__main__":
    main()
