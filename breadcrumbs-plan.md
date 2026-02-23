# Plan: Apply Breadcrumbs Strategy to Animal Kingdom

## Problem Statement

The Animal Kingdom repo has 160K+ files. Copilot (and users) need a way to navigate efficiently without loading thousands of files into context.

## The Breadcrumbs Approach (from `breadcrumbs` repo)

The breadcrumbs repo uses **YAML frontmatter as navigational metadata** in Markdown files:

```yaml
---
title: "Async Streams"
tags: ["async", "streaming", "linq"]
related: ["path/to/related-doc.md"]
links_from: ["path/to/parent-doc.md"]
---
```

Key concepts:
1. **Tags** — Enable tag-based discovery for multi-concept queries
2. **related** — Points to peer documents (one hop away)
3. **links_from** — Backlinks from parent/referencing docs
4. **Traversal depth** — Control how many hops to explore (0-3)

The `frontmatter-context-traversal` skill teaches Copilot to:
- Start from a single entry point
- Read frontmatter to discover related docs
- Expand only as needed (minimum context first)

---

## How This Applies to Animal Kingdom

### Current State

Animal Kingdom has:
- **C# files** with XML doc comments (species, genus, family, etc.)
- **copilot-instructions.md** explaining structure
- **No navigational metadata** beyond folder hierarchy

### Proposed Changes

#### 1. Add Breadcrumb Documents (Markdown with Frontmatter)

Create navigational Markdown files at key taxonomic levels:

```
root/
└── Metazoa/
    ├── breadcrumb.md              # Overview of Metazoa, links to phyla
    └── Chordata/
        ├── breadcrumb.md          # Overview of Chordata, links to classes
        └── Mammalia/
            ├── breadcrumb.md      # Overview of Mammalia, links to orders
            └── Carnivora/
                └── breadcrumb.md  # Overview of Carnivora, links to families
```

Each breadcrumb.md would have frontmatter like:

```yaml
---
title: "Mammalia (Mammals)"
description: "Class containing ~6,400 species of warm-blooded vertebrates"
category: "taxonomy/class"
tags: ["mammalia", "mammals", "warm-blooded", "vertebrates", "chordata"]
status: "Living"
updated: "2026-02-23"
related: ["../breadcrumb.md", "Carnivora/breadcrumb.md", "Primates/breadcrumb.md"]
links_from: ["../breadcrumb.md"]
species_count: 6400
notable_genera: ["Canis", "Felis", "Homo", "Elephas"]
---
```

#### 2. Add Copilot Skills

Copy/adapt the breadcrumbs skills:

```
.github/
└── skills/
    ├── taxonomy-traversal/SKILL.md    # How to navigate the hierarchy
    └── species-lookup/SKILL.md        # How to find specific species
```

#### 3. Update copilot-instructions.md

Reference the skills and explain the traversal strategy:

```markdown
### Context Traversal

Use the **taxonomy-traversal** skill to find species/taxa efficiently:
1. Start at the closest known breadcrumb.md
2. Read frontmatter to identify related breadcrumbs
3. Traverse one hop at a time
4. Use tag intersection for cross-cutting queries

See: `.github/skills/taxonomy-traversal/SKILL.md`
```

---

## Implementation Todos

| ID | Task | Description |
|----|------|-------------|
| `skills-copy` | Copy skills from breadcrumbs | Adapt markdown-frontmatter and frontmatter-context-traversal |
| `breadcrumb-template` | Create breadcrumb.md template | Frontmatter schema for taxonomy breadcrumbs |
| `breadcrumb-top-level` | Create top-level breadcrumbs | Metazoa, Chordata, Mammalia, etc. |
| `breadcrumb-families` | Create family-level breadcrumbs | Canidae, Felidae, etc. (highest value) |
| `instructions-update` | Update copilot-instructions.md | Reference the skills and traversal strategy |

---

## Benefits for Animal Kingdom

1. **Efficient navigation** — Copilot can traverse 160K files using frontmatter instead of scanning
2. **Tag-based discovery** — Find species by conservation status, habitat, diet
3. **Minimum context** — Load only what's needed for the current question
4. **Human-readable** — Breadcrumbs serve as documentation too

---

## Estimated Scope

- **Skills**: 2 files to create/adapt
- **breadcrumb.md files**: Start with ~10-20 at key levels (phylum, class, order, family)
- **copilot-instructions.md**: ~20 lines to add

---

## Decision Points

Before implementing, consider:

1. **How many breadcrumb.md files?** — Every folder? Only major taxonomic levels?
2. **Auto-generate breadcrumbs?** — Use the existing data to generate frontmatter
3. **Tag strategy** — What tags are most useful? (conservation status, habitat, diet, region)
