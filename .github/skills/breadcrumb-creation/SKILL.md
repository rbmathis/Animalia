---
name: markdown-frontmatter
description: Add and maintain YAML frontmatter in breadcrumb.md files. Use when creating or editing breadcrumb files for taxonomy navigation.
license: MIT
---

# Markdown YAML Frontmatter for Animal Kingdom

## Goal

Ensure every `breadcrumb.md` file includes proper YAML frontmatter with consistent, searchable metadata that enables traversal and discovery.

## Required Frontmatter Fields

When creating or editing any `breadcrumb.md` file, include a YAML frontmatter block at the top with these fields:

- `title`: Human-readable title with common name (e.g., "Canidae (Dog Family)")
- `description`: One-paragraph summary (string)
- `category`: Category as `taxonomy/{rank}` (e.g., `taxonomy/family`)
- `tags`: List of keywords for discovery (array of strings) — **see Tag Selection Guide below**
- `status`: One of `Living`, `Extinct`, `Mixed` (string)
- `updated`: Last meaningful edit date (ISO-8601 `YYYY-MM-DD`)
- `related`: Paths to closely related breadcrumbs (array of strings)
- `links_from`: Paths that reference this breadcrumb (array of strings)

## Taxonomy-Specific Fields

- `rank`: Taxonomic rank (kingdom, phylum, class, order, family, genus)
- `taxId`: NCBI Taxonomy ID (integer, optional)
- `parent`: Path to parent breadcrumb (e.g., `../breadcrumb.md`)
- `children_count`: Number of immediate child taxa
- `species_count`: Total species in this taxon

## Tag Selection Guide

Tags enable **tag-based discovery** — finding documents that bridge multiple concepts.

### Tag Categories for Animal Kingdom

1. **Taxonomic tags**: The taxon name and rank (e.g., `canidae`, `family`, `carnivora`)
2. **Behavior tags**: Behavioral characteristics (e.g., `pack-hunter`, `social`, `nocturnal`)
3. **Conservation tags**: IUCN status (e.g., `endangered`, `least-concern`)
4. **Habitat tags**: Environment (e.g., `arctic`, `temperate`, `marine`)
5. **Diet tags**: Feeding type (e.g., `carnivore`, `herbivore`, `omnivore`)

### Best Practices

- Include **3–8 tags** per breadcrumb
- Use **consistent naming**: lowercase, hyphenated (e.g., `pack-hunter` not `PackHunter`)
- Include the **taxon name** and **rank** as tags
- Include **synonyms** when commonly searched (e.g., both `wolves` and `canis`)
- Think: "What concepts does this breadcrumb bridge?"

### Example: Good Tag Selection

```yaml
# Genus breadcrumb for Canis
tags: ["canis", "wolves", "dogs", "jackals", "pack-hunter", "carnivore"]

# Family breadcrumb for Felidae
tags: ["felidae", "cats", "felines", "solitary", "carnivore", "ambush-predator"]
```

### Anti-patterns

- ❌ Too few tags: `tags: ["animal"]` — not discoverable
- ❌ Too generic: `tags: ["species", "taxonomy"]` — no signal
- ❌ Inconsistent naming: `tags: ["PackHunter", "pack_hunter"]` — won't match searches

## Template

Use this template when creating new breadcrumb files:

```yaml
---
title: "<TaxonName> (<Common Description>)"
description: "<1–3 sentence summary of the taxon>"
category: "taxonomy/<rank>"
tags: ["<taxon-name>", "<rank>", "<key-trait>"]
status: "Living"
updated: "YYYY-MM-DD"
related: ["../SiblingTaxon/breadcrumb.md"]
links_from: ["../breadcrumb.md"]
rank: "<rank>"
taxId: <NCBI_ID>
parent: "../breadcrumb.md"
children_count: <N>
species_count: <N>
---
```

## Process

1. Determine whether you're creating/editing a breadcrumb.md file.
2. If the file has no frontmatter, add a new YAML frontmatter block at the top.
3. If the file has frontmatter, preserve existing fields and add any missing required fields.
4. **Select tags strategically** using the Tag Selection Guide above.
5. Update `updated` to today's date (ISO `YYYY-MM-DD`) when changes are non-trivial.
6. Keep `related` and `links_from` as **workspace-relative paths** (use `/` separators).
7. Populate `links_from` with the parent breadcrumb path.

## Guardrails

- Don't invent relationships. If you're unsure, leave `related: []` and/or `links_from: []`.
- Don't rewrite content just to add metadata; keep the diff focused.
- Use workspace-relative paths starting from repo root (e.g., `root/Metazoa/Chordata/breadcrumb.md`).
