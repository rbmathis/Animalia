---
applyTo: "**/breadcrumb.md"
---

# Breadcrumb File Instructions

Breadcrumb files are **the primary navigation entry point** for taxonomy levels. Read these **before** opening `.cs` files.

## Purpose

Breadcrumbs aggregate metadata from child taxa, enabling efficient navigation without scanning hundreds of files.

## YAML Frontmatter Structure

```yaml
---
title: "Canis"                           # Taxon name
description: "Genus containing 28 species."
category: "taxonomy/genus"               # taxonomy/{rank}
tags: ["canis", "genus", "endangered"]   # Searchable keywords
status: "Living"                         # Living, Extinct
rank: "genus"                            # kingdom, phylum, class, order, family, genus
taxId: 9611                              # NCBI Taxonomy ID
parent: "../breadcrumb.md"               # Relative path to parent
related: ["../Vulpes/breadcrumb.md"]     # Sibling taxa
links_from: ["../breadcrumb.md"]         # What references this
children_count: 2                        # Sub-taxa count
species_count: 28                        # Total species in subtree
characteristics: [...]                   # Key traits
species:                                 # Species array (genus level only)
  - file: "Canis_lupus.cs"
    name: "Canis lupus"
    common_name: "timber wolf"
    conservation: "Least Concern"
    enriched: true
endangered_species: [...]                # Quick lookup of threatened species
genera:                                  # Genera array (family level)
  - name: "Canis"
    path: "Canis/breadcrumb.md"
---
```

## Navigation Fields

| Field | Use Case |
|-------|----------|
| `species` | List all species in genus without reading `.cs` files |
| `genera` | List all genera in family |
| `parent` | Navigate up one rank |
| `related` | Find sibling families/genera |
| `links_from` | See what references this breadcrumb |
| `tags` | Search by behavior, habitat, conservation status |
| `endangered_species` | Quick lookup of threatened species |

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

# Find all genus breadcrumbs in an order
ls root/**/Carnivora/*/*/breadcrumb.md
```

## Anti-Patterns

- ❌ Opening all `.cs` files to count species → Use `species_count`
- ❌ Grepping `.cs` files for conservation status → Use `species` array
- ❌ Listing directories to find genera → Use `genera` array
