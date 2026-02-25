---
applyTo: "**/breadcrumb.md"
---

# Breadcrumb File Instructions

Breadcrumb files are **the primary navigation entry point** for taxonomy levels. Read these **before** opening `.cs` files.

## Purpose

Breadcrumbs aggregate metadata from child taxa, enabling efficient navigation without scanning hundreds of files.

## YAML Frontmatter Structure (Lean Schema v2)

```yaml
---
title: "Canis"                           # Taxon name
description: "Genus containing 28 species."
category: "taxonomy/genus"               # taxonomy/{rank}
tags: ["canis", "genus", "endangered", "has-pets"]  # Searchable keywords
status: "Living"                         # Living, Extinct
rank: "genus"                            # kingdom, phylum, class, order, family, genus
taxId: 9611                              # NCBI Taxonomy ID
parent: "../breadcrumb.md"               # Relative path to parent
related: ["../Vulpes/breadcrumb.md"]     # Sibling taxa
links_from: ["../breadcrumb.md"]         # What references this
children_count: 2                        # Sub-taxa count
species_count: 28                        # Total species in subtree
characteristics: [...]                   # Key traits
species_data:                            # Species lookup table (genus level)
  Canis_lupus:                           # Key = file stem (file = key + ".cs")
    common_name: "timber wolf"           # Common name
    conservation: "LC"                   # IUCN code
    pet: true                            # Only present if true
  Canis_aureus:
    common_name: "Golden Jackal"
    conservation: "LC"
endangered_species: [...]                # Quick lookup of threatened species
genera: ["Canis", "Vulpes", ...]         # Simple list (family level)
pet_genera: ["Canis", "Felis"]           # Genera with pets (family level)
pet_families: ["Canidae", "Felidae"]     # Families with pets (order+ level)
---
```

## Key Schema Principles

**Lean data**: Only store non-derivable information.

| Derivable | Formula |
|-----------|---------|
| Species file | `{key}.cs` |
| Species name | `{key}` with `_` → ` ` |
| Genus path | `{name}/breadcrumb.md` |

**IUCN codes**: LC, NT, VU, EN, CR, EW, EX, DD, UK

## Navigation Fields

| Field | Use Case |
|-------|----------|
| `species_data` | Lookup species info by file stem |
| `genera` | List all genera in family (names only) |
| `parent` | Navigate up one rank |
| `related` | Find sibling families/genera |
| `tags` | Search by behavior, habitat, `has-pets` |
| `pet_genera` | Genera containing pet species |
| `pet_families` | Families containing pets |

## Traversal Depth

| Depth | Use Case | Example |
|-------|----------|---------|
| **0** | Single lookup | "Get Canis lupus conservation status" → Read genus breadcrumb |
| **1** | Standard navigation | "List all endangered dogs" → Read family breadcrumb |
| **2** | Cross-cutting | "Compare pack behavior across Carnivora" |

## Search Strategies

```bash
# Find endangered species in a family
grep "endangered" root/**/Canidae/**/breadcrumb.md

# Find taxa by behavior tag
grep "pack-hunter" root/**/breadcrumb.md

# Find pet species
grep "has-pets" root/**/breadcrumb.md

# Find pet mammals
grep "has-pets" root/**/Mammalia/**/breadcrumb.md
```

## Deriving Paths

```python
# From species_data key to file
file = f"{key}.cs"        # Canis_lupus -> Canis_lupus.cs

# From species_data key to species name
name = key.replace("_", " ")  # Canis_lupus -> Canis lupus

# From genus name to path
path = f"{name}/breadcrumb.md"  # Canis -> Canis/breadcrumb.md
```

## Anti-Patterns

- ❌ Opening all `.cs` files to count species → Use `species_count`
- ❌ Grepping `.cs` files for conservation status → Use `species_data`
- ❌ Listing directories to find genera → Use `genera` array