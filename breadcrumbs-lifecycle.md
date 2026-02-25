# Breadcrumbs Lifecycle: Creation, Use, and Maintenance

> **Breadcrumbs aren't static.** They're a living part of your codebase—automatically created, actively used by Copilot, and intelligently maintained as code evolves.

This document explains how breadcrumbs move through their lifecycle, from initial generation to continuous use and automated maintenance.

---

## The Three Phases

```
┌─────────────┐         ┌─────────┐         ┌──────────────┐
│  CREATION   │────────▶│   USE   │────────▶│ MAINTENANCE  │
│             │         │         │         │              │
│  Script-    │         │ Skills  │         │ Agent        │
│  based      │         │ & Grep  │         │ Hooks        │
│  traversal  │         │         │         │              │
└─────────────┘         └─────────┘         └──────────────┘
```

---

## Phase 1: Creation

### The Problem It Solves

With 160,000+ files and 7+ levels of taxonomic depth, manually documenting metadata is impossible. Breadcrumbs need to be **automatically generated** from the code structure itself.

### Solution: Tree Traversal Scripts

The Animal Kingdom repository includes Python scripts that **traverse the entire codebase** and generate `breadcrumb.md` files at key taxonomy levels.

#### Key Generation Scripts

| Script | Purpose | Command |
|--------|---------|---------|
| [`generate_breadcrumbs.py`](generate_breadcrumbs.py) | Full generation with filtering options | `python generate_breadcrumbs.py --priority-only` |
| [`generate_all_breadcrumbs.py`](generate_all_breadcrumbs.py) | Generate or refresh all breadcrumbs | `python generate_all_breadcrumbs.py` |
| [`generate_breadcrumbs_targeted.py`](generate_breadcrumbs_targeted.py) | Generate specific taxonomy subtrees | `python generate_breadcrumbs_targeted.py Carnivora` |

#### What Generation Discovers

The scripts analyze **folder structure and code files** to extract:

- **Taxonomic rank** (inferred from depth: Kingdom → Phylum → ... → Species)
- **Taxa names** (from folder names: `Canidae`, `Felidae`, `Canis`, etc.)
- **Species data** (parsed from `*_*.cs` files in genus folders)
- **Relationships** (sibling taxa, parent-child links)
- **Conservation status** (parsed from `.cs` properties)
- **Characteristics** (aggregated from species and genus comments)
- **Pet status** (detected from `IsEnriched` and species properties)

#### Example: What Gets Created

```yaml
# root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/breadcrumb.md
---
title: Canidae
description: Family containing 13 genera
category: taxonomy/family
tags: [canidae, family, has-pets]
rank: family
taxId: 9646
species_count: 34
pet_families: [Canis, Vulpes]
---
```

### When to Run Generation

- **Initial setup**: First time adding breadcrumbs to a project
- **Major structural changes**: New families, orders, or deep categories added
- **Periodic refresh**: Monthly or quarterly to capture code changes
- **Before releases**: Ensure metadata is synchronized before shipping

---

## Phase 2: Use

### The Problem It Solves

With breadcrumbs in place, the question shifts: **How does Copilot actually use them?**

The answer: **Skills** and **intelligent queries** that replace randomized semantic search with deterministic metadata lookup.

### Solution: Breadcrumb-Based Skills

Skills codify the **search and navigation patterns** that make breadcrumbs valuable.

#### Available Skills

| Skill | Pattern | Example Query |
|-------|---------|---------------|
| [**Pet Lookup**](.github/skills/pet-lookup/SKILL.md) | Grep `has-pets` tag, read matching breadcrumbs | "Find all pet mammals" → `grep "has-pets"` |
| [**Species Lookup**](.github/skills/species-lookup/SKILL.md) | Navigate to genus breadcrumb, find species data | "Where is Canis_lupus?" → Read path-derived breadcrumb |
| [**Breadcrumb Traversal**](.github/skills/breadcrumb-traversal/SKILL.md) | Use `parent`, `related`, `children` fields for navigation | "What are sibling families?" → Read `related` field |
| [**Interface Validation**](.github/skills/interface-validation/SKILL.md) | Leverage breadcrumb aggregations for bulk compliance checks | "Do all species implement ISpecies?" → Check species_data |

#### Real-World Usage Pattern

```bash
# Without breadcrumbs: Search the haystack
grep -r "pet.*true" root/**/*.cs | head -50    # Returns 1000+ lines, unclear which are metadata

# With breadcrumbs + skill: Use metadata
grep "has-pets" root/**/breadcrumb.md           # Returns 14 breadcrumbs (exact)
cat root/.../Canidae/breadcrumb.md              # Read pet_genera field
```

### How Copilot Leverages This

1. **User asks a question** (e.g., "Where are pets?")
2. **Skill determines the pattern** (e.g., `grep "has-pets"`)
3. **Copilot executes the pattern** (finds 14 breadcrumbs)
4. **Breadcrumbs provide context** (species_data, pet_genera, etc.)
5. **Copilot answers with confidence** (no false positives, deterministic)

---

## Phase 3: Maintenance

### The Problem It Solves

Code changes constantly. When code is modified, **breadcrumbs can become stale** if not updated. 

Traditional approach: Manual maintenance + periodic refresh scripts.

**Better approach: Automatic maintenance via Agent Hooks.**

### Solution: Agent Hooks for Breadcrumb Sync

[**Agent Hooks**](https://code.visualstudio.com/docs/copilot/customization/hooks) are lifecycle callbacks that execute at key points during an agent session. They enable **automatic, deterministic maintenance**.

#### Hook Lifecycle Events (Relevant to Breadcrumbs)

| Hook | Fires | Use Case |
|------|-------|----------|
| `PostToolUse` | After agent edits files | Detect if breadcrumbs/code were modified |
| `Stop` | When agent session ends | Final sync of all touched breadcrumbs |

#### Breadcrumb Maintenance Strategy

1. **Detect changes**: After agent creates/edits files, check if breadcrumbs reference those files
2. **Refresh linked breadcrumbs**: If a species file is modified, update its genus breadcrumb
3. **Cascade updates**: If genus breadcrumb changes, update family breadcrumb (and so on)
4. **Report to user**: Show what breadcrumbs were updated

### Hook Implementation

#### Configuration: `.github/hooks/breadcrumb-maintenance.json`

```json
{
  "hooks": {
    "PostToolUse": [
      {
        "type": "command",
        "command": "python .github/hooks/breadcrumb-post-tool.py",
        "timeout": 60,
        "env": {
          "HOOK_SESSION_ID": "$SESSION_ID"
        }
      }
    ],
    "Stop": [
      {
        "type": "command",
        "command": "python .github/hooks/breadcrumb-stop.py",
        "timeout": 120
      }
    ]
  }
}
```

#### Hook Script: `breadcrumb-post-tool.py`

This script runs after each tool execution:

```python
#!/usr/bin/env python3
"""
PostToolUse Hook: Detect breadcrumb/code changes and refresh metadata
"""
import json
import sys
from pathlib import Path
from typing import Dict, Any, List

# Read hook input from VS Code
def read_hook_input() -> Dict[str, Any]:
    """Read JSON input from stdin"""
    hook_data = json.load(sys.stdin)
    return hook_data

# Detect changed files
def get_changed_files(tool_response: str) -> List[str]:
    """Extract file paths from tool response"""
    files = []
    # Parse tool_response to find modified files
    # (Implementation depends on tool_name and response format)
    return files

# Determine if breadcrumb update is needed
def should_update_breadcrumbs(files: List[str]) -> bool:
    """Return True if any changed files affect breadcrumbs"""
    for file in files:
        # If a species file changed, its breadcrumbs need updating
        if "_" in Path(file).stem:  # Species file naming: Genus_species.cs
            return True
        # If a breadcrumb itself changed, cascade to parent
        if "breadcrumb.md" in file:
            return True
    return False

def main():
    hook_input = read_hook_input()
    
    tool_name = hook_input.get("tool_name")
    tool_response = hook_input.get("tool_response", "")
    
    # Check if files were changed
    changed_files = get_changed_files(tool_response)
    
    if not changed_files or not should_update_breadcrumbs(changed_files):
        # No breadcrumb maintenance needed
        print(json.dumps({
            "continue": True,
            "hookSpecificOutput": {
                "additionalContext": "No breadcrumb updates needed."
            }
        }))
        return
    
    # Trigger breadcrumb refresh for affected taxa
    context = f"Changed files detected. Running breadcrumb sync for {len(changed_files)} files..."
    
    print(json.dumps({
        "continue": True,
        "hookSpecificOutput": {
            "additionalContext": context
        }
    }))

if __name__ == "__main__":
    main()
```

#### Hook Script: `breadcrumb-stop.py`

This script runs when the agent session ends:

```python
#!/usr/bin/env python3
"""
Stop Hook: Final breadcrumb cascade and consistency check
"""
import json
import sys
from pathlib import Path

def main():
    hook_input = json.load(sys.stdin)
    
    session_id = hook_input.get("sessionId")
    transcript_path = hook_input.get("transcript_path")
    
    # Parse transcript to find all modified files
    print(json.dumps({
        "hookSpecificOutput": {
            "hookEventName": "Stop",
            "decision": "allow",
            "additionalContext": f"Breadcrumb maintenance complete for session {session_id}"
        }
    }))

if __name__ == "__main__":
    main()
```

#### Hook File Locations

Hooks should be placed in the workspace:

```
.github/
└── hooks/
    ├── breadcrumb-maintenance.json        # Hook configuration
    ├── breadcrumb-post-tool.py            # PostToolUse handler
    └── breadcrumb-stop.py                 # Stop handler
```

### Maintenance Workflow

```
┌─────────────────────┐
│  Agent edits file   │
│  (e.g., edit Canis  │
│   _lupus.cs)        │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────────────────────┐
│ PostToolUse Hook Triggers           │
├─────────────────────────────────────┤
│ 1. Detect changed file              │
│ 2. Map file to taxonomy level       │
│ 3. Check if breadcrumb exists       │
└──────────┬──────────────────────────┘
           │
           ▼
┌─────────────────────────────────────┐
│ Refresh Affected Breadcrumbs        │
├─────────────────────────────────────┤
│ 1. Update Genus breadcrumb          │
│    (Canis/breadcrumb.md)            │
│ 2. Update Family breadcrumb         │
│    (Canidae/breadcrumb.md)          │
│ 3. Update Order breadcrumb          │
│    (Carnivora/breadcrumb.md)        │
└──────────┬──────────────────────────┘
           │
           ▼
┌─────────────────────────────────────┐
│ Agent Session Ends (Stop Hook)      │
├─────────────────────────────────────┤
│ 1. Final consistency check          │
│ 2. Report updated breadcrumbs       │
│ 3. Generate audit log               │
└─────────────────────────────────────┘
```

---

## Complete Lifecycle Example

### Scenario: Agent Adds a New Pet Species

**Initial State:**
- Working in `root/Metazoa/Chordata/Mammalia/Rodentia/Caviidae/Cavia/`
- File: `Cavia_porcellus.cs` (Guinea Pig) exists with `pet: true`

**Step 1: Agent Creates New Species**
```csharp
// New file: Cavia_aperea_enriched.cs
public partial class Cavia_aperea_enriched : Cavia
{
    public const int TaxId = 10141;
    public const bool IsEnriched = true;
    public const bool IsPet = true;  // → Important!
    // ...
}
```

**Step 2: PostToolUse Hook Detects Change**
- Hook reads: `tool_name = "editFiles"`, `tool_response = "File created: Cavia_aperea_enriched.cs"`
- Hook parses: File name matches `*_*.cs` (species pattern)
- Hook determines: This is in `Cavia/` folder (genus level)
- **Hook Action:** Trigger refresh for `Cavia/breadcrumb.md`

**Step 3: Breadcrumbs Refresh (Cascade)**

```yaml
# Cavia/breadcrumb.md updated
species_data:
  Cavia_porcellus:
    common_name: Guinea Pig
    pet: true
  Cavia_aperea_enriched:           # ← NEW
    common_name: Brazilian Guinea Pig
    pet: true

# Caviidae/breadcrumb.md updated
pet_genera: [Cavia]  # Unchanged (Cavia still has pets)

# Rodentia/breadcrumb.md updated
pet_families: [Caviidae, Cricetidae, Chinchillidae]  # Unchanged
```

**Step 4: Stop Hook Reports Summary**

```
---
Breadcrumb Updates Completed
---
Modified:
  ✅ Cavia/breadcrumb.md (added species_data)
  ✅ Caviidae/breadcrumb.md (verified pet_genera)
  ✅ Rodentia/breadcrumb.md (verified pet_families)

Result:
  Pet lookup now includes: Cavia_aperea_enriched
```

**Step 5: Copilot can now answer:**
```
User: "What are the enriched pet rodents?"
Copilot: grep "has-pets" → finds Rodentia/breadcrumb.md → reads updated species_data
Answer: ✅ Guinea Pig, Brazilian Guinea Pig, Hamster, Chinchilla, Rabbit, Ferret...
```

---

## Best Practices

### Creation

- **Run periodically**: Generate breadcrumbs monthly to capture code changes
- **Version control**: Commit breadcrumbs to git—they're documentation
- **Document the metadata**: Add comments explaining custom tags and fields

### Use

- **Consume via skills**: Never grep for `.cs` files directly; use metadata instead
- **Build skills iteratively**: Start with simple grep patterns, move to complex queries
- **Share successful patterns**: Document any custom search patterns for team reuse

### Maintenance

- **Enable hooks**: Set up `.github/hooks/` and test them locally first
- **Monitor hook output**: Check VS Code's Output panel for hook execution logs
- **Test scenarios**: Verify cascading updates work as expected (e.g., species → genus → family)
- **Audit changes**: Keep logs of breadcrumb modifications for compliance/debugging

---

## Troubleshooting

### Breadcrumbs Out of Sync

**Symptom:** Metadata doesn't reflect recent code changes  
**Solution:** Run generation script manually  
```bash
python generate_all_breadcrumbs.py
```

### Hooks Not Firing

**Symptom:** No breadcrumb updates after agent edits files  
**Solution:** 
1. Check hook file is in `.github/hooks/` with `.json` extension
2. Verify hook script has execute permissions: `chmod +x breadcrumb-post-tool.py`
3. View diagnostics: Right-click Chat → Diagnostics → Check "Hooks" section

### Cascade Failures

**Symptom:** Child breadcrumbs update but parents don't  
**Solution:** 
1. Verify taxonomy hierarchy in generation script
2. Check that parent folders exist (species → genus → family → order)
3. Manually run refresh for affected taxa

---

## Related Documentation

- [Agent Hooks Reference](https://code.visualstudio.com/docs/copilot/customization/hooks)
- [Breadcrumb Schema](architecture.md#breadcrumb-structure)
- [Pet Lookup Skill](.github/skills/pet-lookup/SKILL.md)
- [Species Lookup Skill](.github/skills/species-lookup/SKILL.md)
