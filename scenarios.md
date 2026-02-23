# Scenarios: Testing Copilot on Large Repositories

This document contains scenarios designed to test and demonstrate GitHub Copilot's effectiveness on large codebases. Each scenario simulates a real developer task applied to the Animal Kingdom repository.

---

## 🎯 What We're Proving

1. **Copilot customizations matter at scale** — `copilot-instructions.md` dramatically improves results
2. **Large repos don't break Copilot** — 160K files can be navigated efficiently
3. **Consistent patterns enable better suggestions** — Copilot learns from repo structure
4. **Context management is key** — Minimum-context strategies outperform brute-force

---

## Scenarios

### 🐛 Bug Fixes

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 1 | Fix Incorrect Conservation Status | The Ethiopian Wolf (`Canis_simensis.cs`) has `ConservationStatus => "Endangered status"` but should be `"Endangered"` (following IUCN format). | `Find Canis_simensis and fix its ConservationStatus - it should follow IUCN format (just "Endangered", not "Endangered status")` | Can Copilot find the file, understand the pattern, and suggest the correct fix? |
| 2 | Fix Missing Common Name | Several species have `CommonName => ""` (empty string). Find one and populate it with accurate data. | `Find a species with an empty CommonName and fill it in with the correct common name` | Can Copilot locate stubs (`IsEnriched = false`) and enrich them correctly? |
| 3 | Incorrect Taxonomy Placement | A species file is in the wrong genus folder. Identify the issue and move it. | `Check if Vulpes_vulpes is in the correct genus folder based on its class inheritance` | Can Copilot understand the hierarchical structure and validate placements? |
| 4 | Fix Namespace Mismatch | A species file's namespace doesn't match its folder path (e.g., file is in `Canidae/Vulpes/` but namespace says `Canidae.Canis`). | `Find any species files where the namespace doesn't match the folder path and fix them` | Can Copilot detect and fix namespace/path inconsistencies? |

---

### ✨ Features

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 5 | Add a New Property to All Species | Add `WikipediaUrl` property to all species files. | `Add a WikipediaUrl property to Canis_lupus that generates a Wikipedia link from the SpeciesName. Show me the pattern so I can apply it to other species.` | Can Copilot generate a consistent pattern across 112K species files? |
| 6 | Add Interface for Endangered Species | Create `IEndangered` interface with `string ConservationPlan { get; }` and implement it on all endangered species. | `Create an IEndangered interface and show me how to implement it on Canis_simensis (Ethiopian Wolf) since it's endangered` | Can Copilot identify which species are endangered and add the interface? |
| 7 | Add Diet Classification | Add a `DietType` enum (`Carnivore`, `Herbivore`, `Omnivore`, `Insectivore`) and property. | `Create a DietType enum and add a Diet property to species. Use Canis_lupus as an example - what diet type should a wolf have?` | Can Copilot infer diet type from existing species data? |
| 8 | Create Summary Statistics Class | Create a class that aggregates statistics: total species count, count by conservation status, count by taxonomic rank. | `Create a TaxonomyStatistics class that can count species by conservation status. What properties would it need based on our species data model?` | Can Copilot understand the data model well enough to query it? |

---

### 🔥 Hotfixes

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 9 | Emergency: Remove PII from Comments | A researcher's email accidentally ended up in XML doc comments. Find and remove all instances. | `Search for any email addresses in XML doc comments across the codebase and remove them` | Can Copilot perform a targeted search-and-replace across 160K files? |
| 10 | Hotfix: Compilation Error in New Species | A recently added species file has a syntax error preventing build. Find and fix it. | `There's a syntax error somewhere in the codebase. Find the file with the compilation error and fix it.` | Can Copilot locate compilation errors without IDE support (C# extension disabled)? |

---

### 🔍 Code Discovery & Navigation

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 11 | Find All Pack Animals | Identify all species that have pack/social behavior (wolves, lions, etc.). | `Find species in this repo that are known to live in packs or have social hunting behavior` | Can Copilot search semantically, not just by keyword? |
| 12 | Find Species by Habitat | List all species with `Habitat` containing "Arctic" or "Polar". | `Find all species that live in Arctic or Polar habitats` | Can Copilot efficiently query across 112K species files? |
| 13 | Compare Two Related Species | Compare `Canis_lupus` (wolf) and `Canis_latrans` (coyote) — what properties differ? | `Compare the Grey Wolf (Canis_lupus) and Coyote (Canis_latrans) - what are the key differences in their properties?` | Can Copilot load two files and produce a meaningful diff? |
| 14 | Trace Inheritance Chain | For `Canis_lupus`, show the full inheritance: Species → Genus → Family → Order → Class → Phylum. | `Show me the complete inheritance hierarchy for Canis_lupus from species up to phylum` | Can Copilot navigate the folder hierarchy to find parent classes? |

---

### 📝 Documentation

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 15 | Generate README for a Genus | Create a `README.md` for the `Canis` folder summarizing all species within it. | `Create a README.md for the Canis genus folder that lists all wolf species and their conservation statuses` | Can Copilot aggregate data from multiple files into documentation? |
| 16 | Document the Taxonomy Pattern | Write documentation explaining how the folder structure maps to biological taxonomy. | `Explain how this repository's folder structure maps to biological taxonomy. What pattern does it follow?` | Can Copilot infer and articulate the architectural pattern? |

---

### 🧪 Refactoring

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 17 | Extract Common Base Properties | Many species repeat the same properties. Extract common properties to a shared base class. | `What properties are repeated across all species files? Should we extract them to a common base class?` | Can Copilot identify duplication across 112K files and suggest consolidation? |
| 18 | Rename Property Across Codebase | Rename `SpeciesCharacteristics` to `DistinguishingFeatures` everywhere. | `I want to rename SpeciesCharacteristics to DistinguishingFeatures across all species files. What's the safest way to do this?` | Can Copilot perform a safe rename across 160K files? |
| 19 | Convert String Properties to Enums | `ConservationStatus` is a string but should be an enum. Create the enum and update all usages. | `ConservationStatus is currently a string. Create a ConservationStatus enum based on IUCN categories and show me how to update a species to use it.` | Can Copilot identify all unique values and generate the enum? |

---

### 🧩 Cross-Cutting Queries

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 20 | Find Species Needing Enrichment | List all species where `IsEnriched = false` — these are stubs needing data. | `Find species files that are stubs (IsEnriched = false) and need enrichment. Show me a few examples from different families.` | Can Copilot efficiently filter by a boolean property? |
| 21 | Identify Missing Interfaces | Find genera that don't implement their expected interface (e.g., `Canis` should implement `ICanis`). | `Check if the Canis genus class properly implements ICanis. Are there any missing interface implementations?` | Can Copilot validate structural patterns across the codebase? |

---

## 🧭 Breadcrumb Navigation Tests

These scenarios verify that breadcrumb.md files are being used for efficient navigation.

| # | Scenario | Query | Expected Behavior | Anti-pattern |
|---|----------|-------|-------------------|--------------|
| 22 | Species Lookup (Depth 0) | "What is the conservation status of Canis lupus?" | Read `Canis/breadcrumb.md` → find in species array | Opening `Canis_lupus.cs` or grepping |
| 23 | Genus Listing (Depth 0) | "List all bear genera" | Read `Ursidae/breadcrumb.md` → return genera array | `Get-ChildItem -Directory` |
| 24 | Endangered in Family (Depth 1) | "Which Canidae are endangered?" | Read `Canidae/breadcrumb.md` → check `endangered_species` | Grep "Endangered" in all .cs files |
| 25 | Tag-Based Discovery (Depth 1-2) | "Find pack-hunting mammals" | Search breadcrumbs for `tags: ["pack-hunter"]` | Grep characteristics in .cs files |
| 26 | Cross-Family Compare (Depth 2) | "Compare Canidae vs Felidae species counts" | Read both family breadcrumbs | Count files in directories |
| 27 | Lateral Navigation | "What families are related to Canidae?" | Read `Canidae/breadcrumb.md` → check `related` array | Guess or list sibling folders |
| 28 | Backlink Traversal | "What links to the Canis breadcrumb?" | Check `links_from` in `Canis/breadcrumb.md` | Manual folder traversal |

### Validation Checklist

When Copilot answers taxonomy questions, verify:
- [ ] Reads `breadcrumb.md` files first (not .cs files)
- [ ] Uses species array from genus breadcrumb (not individual files)
- [ ] Tag searches target breadcrumbs (not source code)
- [ ] Uses `related`/`links_from` for navigation
- [ ] Respects traversal depth (doesn't over-expand context)

---

## How to Use These Scenarios

1. **Baseline test**: Try each scenario WITHOUT `copilot-instructions.md`
2. **With customization**: Try the same scenario WITH the instructions
3. **Compare results**: Document accuracy, speed, and context efficiency
4. **Iterate**: Use failures to improve `copilot-instructions.md`

---

## Scoring Rubric

| Dimension | Description |
|-----------|-------------|
| **Accuracy** | Did Copilot find the right files/code? |
| **Efficiency** | How many files were loaded into context? |
| **Completeness** | Was the full task completed or just started? |
| **Pattern Recognition** | Did Copilot leverage repo conventions? |
| **Autonomy** | How much human guidance was needed? |
