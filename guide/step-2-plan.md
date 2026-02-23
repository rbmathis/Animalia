# Plan: Update copilot-instructions.md with Repository Scale Context

> **Goal**: Enhance `.github/copilot-instructions.md` to help Copilot understand the repo's scale, structure, patterns, and how to work efficiently within context limits.

---

## Recommended Additions

### 1. **Repository Scale Section** (new)
Add concrete stats so Copilot understands scope:
- 161,663 files | 3.8M lines | 1.6M code lines | 123.6 MB
- 146K C# species files, 15.5K .csproj files
- Folder depth: 7-12 levels (taxonomic hierarchy)
- No solution file — each folder has its own .csproj

### 2. **Interface Dual-Pattern** (expand existing)
Document that each rank has TWO interface types:
- **Ranking interface** (`ICarnivora`) — all properties for that rank
- **Trait interfaces** (`ICarnivore`, `IPredator`) — focused biological behaviors

### 3. **Namespace Convention** (new)
```
AnimalKingdom.root.Metazoa.Chordata.{Class}.{Order}.{Family}.{Genus}
```
Namespaces mirror folder paths exactly.

### 4. **Special Species Types** (new)
| Type | Pattern | Example |
|------|---------|---------|
| Regular | `Genus_species.cs` | `Canis_lupus.cs` |
| Hybrid | `Genus_species_x_Genus_species.cs` | `Equus_caballus_x_Equus_asinus.cs` |
| Environmental | `*_environmental_sample.cs` | DNA-only specimens |
| Unclassified | `unclassified_*` folders | Taxonomically uncertain |

### 5. **Full Property List** (expand existing)
**Stub species:** `IsEnriched`, `SpeciesName`, `CommonName`, `TaxonomicRank`, `TaxId`

**Enriched species add:** `SpeciesCharacteristics[]`, `ConservationStatus`, `AverageLifespanYears`, `ReproductionMethod`, `AdultLengthCm`

### 6. **Search Strategies** (new section)
Best practices for this scale:
- **TaxId lookup**: Fastest way to find exact species (links to NCBI)
- **Glob patterns over semantic search**: `**/Canidae/**/*.cs` beats broad text search
- **Folder = classification**: Navigate by folder for taxonomic exploration
- **Check `IsEnriched` first**: Stubs have placeholder data

### 7. **What's NOT in This Repo** (new)
- No unit tests
- No solution file (.sln)
- No shared utilities outside `root/`
- No runtime/executable — reference-only codebase

### 8. **Known Data Quirks** (new)
- Some templated data wasn't customized (e.g., family names may say "Canidae" generically)
- Environmental samples lack most biological properties
- Enrichment is AI-generated — verify critical facts externally

---

## Context Conservation Additions

### 9. **Context Budgeting** (new)
Provide approximate file sizes to help Copilot plan reads:

| File Type | Approx. Lines | When to Read |
|-----------|---------------|--------------|
| Species (stub) | 30–40 | Basic info |
| Species (enriched) | 60–100 | Full details |
| Genus class | 30–50 | Inheritance context |
| Interface | 20–40 | Contract reference |
| **Full context** | ~150 max | species + genus + interface |

### 10. **Predictable Patterns** (new)
These patterns are **deterministic**—don't waste context reading files to discover them:

| Pattern | Rule |
|---------|------|
| Namespace | `AnimalKingdom.` + folder path (dots for slashes) |
| Class name | Same as filename minus `.cs` |
| Parent class | Folder name one level up |
| Interface name | `I` + class name |

### 11. **Anti-Patterns** (new)
Critical for context preservation:

- ❌ **Never list entire genus folders** — some have 500+ species files
- ❌ **Never semantic search without constraints** — 161K files will overwhelm
- ❌ **Never build inheritance tree dynamically** — it's static and documented
- ❌ **Never read sibling species** unless explicitly comparing them

### 12. **Efficient Lookup Strategies** (new)

| Task | Efficient Approach | Avoid |
|------|-------------------|-------|
| Find specific species | Grep for `TaxId: {id}` or file glob `**/*_{species}.cs` | Semantic search |
| Understand inheritance | Read genus file only (parent is documented) | Walking up folder tree |
| Check conservation status | Read single species file, check `ConservationStatus` | Listing all species |
| Find all endangered in family | `grep -r "Endangered\|Critically" **/FamilyName/**` | Reading each file |

### 13. **Static Reference Data** (embed in instructions)
These never change—include them so Copilot doesn't look them up:

**IUCN Conservation Status Codes:**
| Code | Status |
|------|--------|
| LC | Least Concern |
| NT | Near Threatened |
| VU | Vulnerable |
| EN | Endangered |
| CR | Critically Endangered |
| EW | Extinct in Wild |
| EX | Extinct |

**Taxonomic Rank Hierarchy:**
```
Kingdom → Phylum → Class → Order → Family → Genus → Species
```

### 14. **Self-Contained Files** (new)
Document that species files have **no cross-species dependencies**:
- Species only inherits from genus (one file)
- No imports from sibling species
- No shared utilities to track down
- **Safe to read in isolation**

### 15. **Sampling Strategy for Bulk Analysis** (new)
When analyzing patterns across many files:
1. Pick **one representative per family** (not all species)
2. Use enriched species over stubs for richer data
3. Target major families: Canidae, Felidae, Ursidae as canonical examples

---

## Summary: Context Efficiency Principles

Add a condensed section to instructions:

```markdown
## ⚡ Context Efficiency

1. **TaxId is your primary key** — unique, searchable, links to NCBI
2. **Patterns are deterministic** — namespace/class/parent derivable from path
3. **Species are self-contained** — no sibling dependencies
4. **~150 lines for full inheritance context** — species + genus + interface
5. **Glob > semantic search** — faster, more precise for this structure
6. **Sample, don't enumerate** — one species per family for patterns
```

---

## Implementation Checklist

- [x] Add **Repository Scale** section after "About This Repository"
- [x] Expand **Interface pattern** documentation
- [x] Add **Namespace convention**
- [x] Add **Special species types** table
- [x] Expand **property list** for stubs vs enriched
- [x] Add **Search strategies** section
- [x] Add **What's NOT here** section
- [x] Add **Known quirks** section
- [x] Add **Context Budgeting** table
- [x] Add **Predictable Patterns** (avoid lookups)
- [x] Add **Anti-Patterns** section
- [x] Add **Efficient Lookup Strategies** table
- [x] Embed **Static Reference Data** (IUCN codes, taxonomy hierarchy)
- [x] Document **Self-Contained Files** concept
- [x] Add **Sampling Strategy** guidance
- [x] Add condensed **Context Efficiency** principles

---

## Verification

- [x] Stats match README.md exactly
- [x] Examples are accurate to actual files
- [x] Tone is instructional (Copilot guidance, not documentation)
- [ ] Anti-patterns tested against real scenarios
