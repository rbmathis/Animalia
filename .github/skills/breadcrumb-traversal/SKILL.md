---
name: frontmatter-context-traversal
description: Use YAML frontmatter fields (title/description/tags/related/links_from) to traverse breadcrumbs and pull minimum relevant context. Supports tag-based discovery and configurable traversal depth.
license: MIT
---

# Frontmatter-Driven Context Traversal

## Goal

Before implementing changes or answering queries, bring in **only the minimum context** needed by using YAML frontmatter to locate and traverse the most relevant breadcrumb files.

This skill is designed for the Animal Kingdom repo where breadcrumbs are connected via frontmatter fields like `related` and `links_from`.

## Inputs

- The user's current ask (species lookup, conservation query, taxonomy navigation)
- Any explicitly mentioned taxa or files
- Frontmatter fields in breadcrumb.md files
- **Traversal depth** (optional, default: 1)
  - `depth: 0` — Entry breadcrumb only, no expansion
  - `depth: 1` — Entry breadcrumb + immediate `related`/`links_from` (default)
  - `depth: 2` — Two hops from entry point (use for cross-cutting concerns)
  - `depth: 3+` — Rarely needed; use explicit justification

## Output

A small set of high-signal breadcrumbs (typically 1–6) that you read to understand:

- The taxonomic context and hierarchy
- The relevant species and their properties
- The right place to find the answer

## Process (Minimum-Context First)

1. Extract 3–8 key terms from the ask.
   - Include taxon names, common names, conservation status, traits.
2. Find candidate breadcrumbs quickly:
   - Use glob patterns for known taxa: `**/Canidae/**/breadcrumb.md`
   - Use grep for specific properties: `grep -l "pack-hunter" **/breadcrumb.md`
   - **Use tag-based discovery** for intersection queries (see below).
3. Read the YAML frontmatter of the best 1–3 candidates.
4. Build a small traversal set (respecting configured depth):
   - **Depth 0**: Stop at entry breadcrumb.
   - **Depth 1** (default): Include candidate's `related` and `links_from`.
   - **Depth 2+**: Expand one additional hop per depth level.
   - Stop expanding once you have enough context to act OR reach depth limit.
5. Search within the traversal set only:
   - Look for species in genus breadcrumbs (they have `species` arrays)
   - Look for endangered species in family breadcrumbs (`endangered_species` arrays)
6. Decide and proceed:
   - If context is sufficient, answer the query.
   - If context is insufficient and depth allows, expand by one hop and repeat.
   - If at depth limit and still insufficient, request user guidance.

## Tag-Based Discovery

When a question spans multiple concepts, use tag intersection to find breadcrumbs that bridge them:

### Process

1. Identify 2–3 core concepts from the ask (e.g., "pack-hunter", "endangered", "arctic").
2. Search for breadcrumbs where `tags` contains multiple target concepts:
   ```
   grep -l "pack-hunter" **/breadcrumb.md | xargs grep -l "endangered"
   ```
3. Breadcrumbs matching multiple tags are high-value candidates for entry points.

### Example

**Question**: "Which pack-hunting species are endangered?"

**Tag search**: Find breadcrumbs with tags intersecting `[pack-hunter, endangered]`

| Breadcrumb | Tags | Match Score |
|------------|------|-------------|
| Canidae/breadcrumb.md | pack-hunter, endangered, least-concern | 2/2 ✓ |
| Canidae/Canis/breadcrumb.md | pack-hunter, endangered, critically-endangered | 2/2 ✓ |
| Canidae/Vulpes/breadcrumb.md | solitary, least-concern | 0/2 |

**Result**: Prioritize `Canidae/breadcrumb.md` and `Canis/breadcrumb.md` as entry points.

### When to Use Tag Discovery

- Question spans multiple domains (conservation + behavior + habitat)
- Direct taxonomy path is unknown
- Looking for "bridge" breadcrumbs that connect concepts
- `related`/`links_from` graph doesn't reach the answer

## Depth Selection Guide

| Question Type | Recommended Depth | Example |
|---------------|-------------------|---------|
| Single species lookup | 0 | "What is Canis lupus conservation status?" |
| Species list in genus | 0–1 | "List all Canis species" |
| Conservation in family | 1 | "Which Canidae are endangered?" |
| Cross-family comparison | 2 | "Compare pack behavior: Canidae vs Hyaenidae" |
| Cross-order pattern | 2–3 | "Carnivora social structure patterns" |

## Entry Points

| Query Type | Start From |
|------------|------------|
| Specific species | Genus breadcrumb (has `species` list) |
| Family overview | Family breadcrumb |
| Endangered species | Family breadcrumb (has `endangered_species`) |
| Behavior/habitat query | Search breadcrumbs by tags |
| Unknown taxon | Start at root, traverse down |

## Heuristics

- Prefer files with:
  - matching tags or category
  - **multiple matching tags** (intersection = higher relevance)
  - a very specific title/description
  - high fan-in (`links_from` is non-empty)
- Prefer reading less:
  - Read frontmatter first, not full content
  - Genus breadcrumbs have species lists — no need to open each species file
- Avoid "context hoarding":
  - Don't load all genera when one family breadcrumb suffices

## Guardrails

- Don't assume `related`/`links_from` are perfectly maintained; verify quickly.
- If frontmatter is missing, consider applying the `markdown-frontmatter` skill first.
- Keep the context set small; expand only when blocked.
- **Respect depth limits**: If configured depth is exhausted, surface what's missing rather than silently expanding.
- **Document missed context**: When answering with limited depth, note what related topics were not explored.

When in doubt, start with `depth: 1` and note any gaps in the response.
