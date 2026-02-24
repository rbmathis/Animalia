# Scenarios: Testing Copilot on Large Repositories

This document contains scenarios designed to test and demonstrate GitHub Copilot's effectiveness on large codebases. Each scenario simulates a real developer task applied to the Animal Kingdom repository.

> ⚠️ **IMPORTANT**: When updating scenario descriptions or prompts in this file, also update the corresponding entries in `scenarios.json` to keep them in sync. The harness uses the JSON file for execution.

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
| 2 | Find Where CommonName is Referenced | CommonName property is used across the codebase. Identify all usages and understand the pattern. | `Where is the CommonName property used across the codebase? Show me all the files that reference it.` | Can Copilot find all property usages efficiently? |
| 3 | Show Inheritance Pattern | Understand how species inherit from genus classes. Show all direct subclasses. | `Show me all species classes that directly inherit from the Canis genus class. What's the inheritance pattern?` | Can Copilot navigate class hierarchies and identify all implementations? |
| 4 | Validate Consistency in Family | Verify all species in a family follow consistent data patterns. Check Canidae species for complete/valid properties. | `Check all species in the Canidae family - do they all have valid ConservationStatus values following IUCN format (EX, EW, CR, EN, VU, NT, LC)? Show me any that don't match the pattern.` | Can Copilot validate consistency across a specific family without broad scanning? |

---

### ✨ Features

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 5 | Add a New Property to All Species | Add `WikipediaUrl` property to all species files. | `Add a WikipediaUrl property to Canis_lupus that generates a Wikipedia link from the SpeciesName. Show me the pattern so I can apply it to other species.` | Can Copilot generate a consistent pattern across 112K species files? |
| 6 | Add Validation Layer | Add validation to ConservationStatus property to ensure it matches IUCN standards. | `Add validation to the ConservationStatus property to ensure only valid IUCN values are accepted (EX, EW, CR, EN, VU, NT, LC). Show me where this needs to be added.` | Can Copilot identify all property setters and add consistent validation? |
| 7 | Add Debug Logging | Add debug logging to property getters across species files for troubleshooting. | `Add debug logging to property getters in species files to trace data access. Show me the pattern so I can apply it consistently across all species.` | Can Copilot suggest a DRY logging pattern for instrumentation? |
| 8 | Create Summary Statistics Class | Create a class that aggregates statistics: total species count, count by conservation status, count by taxonomic rank. | `Create a TaxonomyStatistics class that can count species by conservation status. What properties would it need based on our species data model?` | Can Copilot understand the data model well enough to query it? |

---

### 🔥 Hotfixes

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 9 | Impact Analysis: Renaming IPackAnimal | If we rename the `IPackAnimal` interface to `ISocialHunter`, what needs to be updated? | `If we rename IPackAnimal to ISocialHunter, what files would need to change? Show me the impact.` | Can Copilot identify all implementation points and dependents? |
| 10 | Hotfix: Compilation Error in New Species | A recently added species file has a syntax error preventing build. Find and fix it. | `There's a syntax error somewhere in the codebase. Find the file with the compilation error and fix it.` | Can Copilot locate compilation errors without IDE support (C# extension disabled)? |

---

### 🔍 Code Discovery & Navigation

| # | Scenario | Task | Prompt | Tests |
|---|----------|------|--------|-------|
| 11 | Find Implementations of IPackAnimal | Identify all species that implement the `IPackAnimal` interface. | `Which species classes implement the IPackAnimal interface? Show me where it's used.` | Can Copilot find all interface implementations? |
| 12 | Trace Habitat Usage in Logic | Find all conditional logic that uses the Habitat property. What decisions depend on it? | `Where is the Habitat property used in conditional logic or decision-making code? Show me all places that depend on it.` | Can Copilot trace property usage through branching logic and find dependencies? |
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
| 20 | Find Where IsEnriched = false is Referenced | Identify all places where `IsEnriched` property is checked or used. | `Where in the codebase is the IsEnriched property referenced or used? Show me all usages.` | Can Copilot find all property usages across many files? |
| 21 | Validate Interface Contracts | Check that all species classes properly implement required properties from their genus interface. | `Verify that each species class implements all properties required by its genus interface (e.g., all Canis species should have properties defined in ICanis). Find any violations.` | Can Copilot validate contract compliance across inheritance hierarchies? |

---

## 🧭 Breadcrumb Navigation Tests

These scenarios verify that breadcrumb.md files are being used for efficient navigation.

| # | Scenario | Query | Expected Behavior | Anti-pattern |
|---|----------|-------|-------------------|--------------|
| 22 | Analyze Property Distribution Pattern | Understand how properties are distributed across the hierarchy in a family. | `Analyze the Canidae family implementation - which properties are defined at the Canidae family level, at each genus level (Canis, Vulpes, Lycaon, etc.), and at the species level? Is the pattern consistent across all genera? What inconsistencies or violations of the pattern exist?` | Can Copilot navigate a family's hierarchy and identify design patterns and inconsistencies? |
| 23 | Extend High-Level Interface | Add a new capability to a base interface that all derived species must implement. | `Add a GetExtinctionRiskLevel() method to the base Animal interface (at the root level) that calculates extinction risk. All species, genera, and families must implement this. Show me the method signature and implementation strategy.` | Can Copilot understand the impact of interface changes rippling through the hierarchy? |
| 24 | Species Lookup (Depth 0) | "What is the conservation status of Canis lupus?" | Read `Canis/breadcrumb.md` → find in species array | Opening `Canis_lupus.cs` or grepping |
| 25 | Genus Listing (Depth 0) | "List all bear genera" | Read `Ursidae/breadcrumb.md` → return genera array | `Get-ChildItem -Directory` |
| 26 | Endangered in Family (Depth 1) | "Which Canidae are endangered?" | Read `Canidae/breadcrumb.md` → check `endangered_species` | Grep "Endangered" in all .cs files |
| 27 | Tag-Based Discovery (Depth 1-2) | "Find pack-hunting mammals" | Search breadcrumbs for `tags: ["pack-hunter"]` | Grep characteristics in .cs files |
| 28 | Cross-Family Compare (Depth 2) | "Compare Canidae vs Felidae species counts" | Read both family breadcrumbs | Count files in directories |

| 30 | Backlink Traversal | "What links to the Canis breadcrumb?" | Check `links_from` in `Canis/breadcrumb.md` | Manual folder traversal |

| 29 | Lateral Navigation | "What families are related to Canidae?" | Read `Canidae/breadcrumb.md` → check `related` array | Guess or list sibling folders |

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
