

# Plan: Update copilot-instructions.md with Repository Scale Context

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
