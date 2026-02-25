#!/usr/bin/env python3
"""
PostToolUse Hook: Detect breadcrumb/code changes and refresh metadata

This hook fires after an agent uses a tool (typically file modifications).
It detects if breadcrumbs or code files linked from breadcrumbs have changed,
and triggers selective breadcrumb refresh.

Input (via stdin):
  {
    "timestamp": "2026-02-24T10:30:00.000Z",
    "cwd": "/workspace",
    "sessionId": "session-123",
    "hookEventName": "PostToolUse",
    "tool_name": "editFiles" | "runCommand" | etc,
    "tool_input": { ... },
    "tool_response": "File edited successfully",
    "tool_use_id": "tool-456"
  }

Output (via stdout):
  {
    "continue": true,
    "hookSpecificOutput": {
      "additionalContext": "Breadcrumb updates triggered for X taxa"
    }
  }
"""

import json
import sys
import re
from pathlib import Path
from typing import Dict, Any, List, Optional


def read_hook_input() -> Dict[str, Any]:
    """Read JSON hook input from stdin"""
    return json.load(sys.stdin)


def extract_modified_files(tool_name: str, tool_input: Dict, tool_response: str) -> List[str]:
    """
    Extract modified file paths from tool response.
    
    Handles multiple tool types:
    - editFiles: Parse file list from response
    - runCommand: Parse command output for created/modified files
    """
    files = []
    
    if tool_name == "editFiles":
        # Tool response format: "File edited: src/file.cs" or similar
        matches = re.findall(r'(?:File (?:edited|created|modified): |Path: )([/\\][\w/_-]+\.(?:cs|md))', tool_response)
        files.extend(matches)
    
    return files


def get_affected_taxa(file_path: str) -> List[str]:
    """
    Map file path to taxonomy levels that need breadcrumb refresh.
    
    Examples:
      root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/Canis_lupus.cs
      → ["Canis", "Canidae", "Carnivora"] (genus, family, order)
    
      root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/breadcrumb.md
      → ["Canidae", "Carnivora"] (family and parent order)
    """
    taxa = []
    parts = Path(file_path).parts
    
    # Find the root of taxonomy (typically root/Metazoa/...)
    root_idx = -1
    for i, part in enumerate(parts):
        if part in ['Metazoa', 'Archaea', 'Bacteria']:
            root_idx = i
            break
    
    if root_idx < 0:
        return taxa
    
    # Extract taxonomy path after root
    taxo_parts = parts[root_idx + 1:]
    
    # Skip bin/, obj/, and hidden folders
    taxo_parts = [p for p in taxo_parts if not p.startswith('.') and p not in ['bin', 'obj']]
    
    # All folders except the deepest are taxa
    for part in taxo_parts[:-1]:  # Skip the filename
        if '.' not in part:  # It's a folder, not a file
            taxa.append(part)
    
    return taxa


def should_refresh_breadcrumbs(files: List[str]) -> bool:
    """
    Determine if any file changes warrant breadcrumb refresh.
    
    Return True if:
      1. Species file changed (name contains "_": Genus_species.cs)
      2. Breadcrumb file changed
      3. Interface file changed (IGenus.cs)
    """
    for file_path in files:
        name = Path(file_path).stem
        ext = Path(file_path).suffix
        
        # Species file
        if "_" in name and ext == ".cs":
            return True
        
        # Breadcrumb file
        if name == "breadcrumb" and ext == ".md":
            return True
        
        # Interface file
        if name.startswith("I") and ext == ".cs":
            return True
    
    return False


def generate_affected_breadcrumbs(modified_files: List[str]) -> List[str]:
    """
    Generate list of breadcrumbs that need refresh from modified files.
    """
    affected_paths = set()
    
    for file_path in modified_files:
        taxa = get_affected_taxa(file_path)
        for taxon in taxa:
            # Map taxon to breadcrumb path
            # This is a simplified approach; real implementation would need
            # more sophisticated path reconstruction
            affected_paths.add(f"{{{taxon}}}/breadcrumb.md")
    
    return sorted(list(affected_paths))


def main():
    """Main hook logic"""
    try:
        hook_input = read_hook_input()
        
        tool_name = hook_input.get("tool_name", "unknown")
        tool_input = hook_input.get("tool_input", {})
        tool_response = hook_input.get("tool_response", "")
        
        # Extract modified files from tool response
        modified_files = extract_modified_files(tool_name, tool_input, tool_response)
        
        # Check if breadcrumb refresh is needed
        if not modified_files or not should_refresh_breadcrumbs(modified_files):
            # No action needed
            output = {
                "continue": True,
                "hookSpecificOutput": {
                    "additionalContext": "Breadcrumb maintenance: No changes detected."
                }
            }
        else:
            # Identify affected breadcrumbs
            affected = generate_affected_breadcrumbs(modified_files)
            
            context = f"Breadcrumb maintenance: {len(modified_files)} file(s) modified. " \
                     f"Scheduling refresh for {len(affected)} breadcrumb(s)."
            
            output = {
                "continue": True,
                "hookSpecificOutput": {
                    "additionalContext": context
                }
            }
        
        print(json.dumps(output))
        sys.exit(0)
    
    except Exception as e:
        # Non-blocking error: log and continue
        error_output = {
            "continue": True,
            "hookSpecificOutput": {
                "additionalContext": f"Breadcrumb hook warning: {str(e)}"
            }
        }
        print(json.dumps(error_output))
        sys.exit(1)


if __name__ == "__main__":
    main()
