# Animal Kingdom - Copilot Instructions

## 🎯 About This Repository

This is a **large-scale C# taxonomy codebase** representing the biological classification of animals.

**Purpose**: Demonstrate GitHub Copilot best practices for large repositories.

---

## 📊 Repository Scale

| Metric | Value |
|--------|-------|
| Total files | 161,663 |
| Total lines | 3.8M |
| Lines of code | 1.6M |
| Size | 123.6 MB |
| C# files | 146,082 |
| .csproj files | 15,579 |
| Folder depth | 7–12 levels |

> ⚠️ **No solution file** — each folder has its own `.csproj`

---

## 📁 Repository Structure

```
Animalia/
└── root/
    └── Metazoa/
        └── Chordata/           # Phylum
            └── Mammalia/       # Class
                └── Carnivora/  # Order
                    └── Canidae/    # Family
                        └── Canis/  # Genus
                            ├── Canis.cs           # Abstract genus class
                            ├── ICanis.cs          # Genus interface
                            ├── Canis_lupus.cs     # Species (Grey Wolf)
                            └── Canis_latrans.cs   # Species (Coyote)
```

Each taxonomic level contains:
- **Base class** extending parent rank
- **Interface** defining behaviors for that rank
- **Species files** with enriched biological data

### Interface Dual-Pattern

Each rank has **two interface types**:

| Type | Example | Purpose |
|------|---------|--------|
| **Ranking interface** | `ICarnivora` | All properties for that taxonomic level |
| **Trait interfaces** | `ICarnivore`, `IPredator` | Focused biological/behavioral contracts |

### Namespace Convention

```
AnimalKingdom.root.Metazoa.Chordata.{Class}.{Order}.{Family}.{Genus}
```

Namespaces **mirror folder paths exactly** — derive from path, don't look up.

---

## 🧬 File Patterns

### Species File Types

| Type | Pattern | Example |
|------|---------|--------|
| Regular | `Genus_species.cs` | `Canis_lupus.cs` |
| Hybrid | `Genus_species_x_Genus_species.cs` | `Equus_caballus_x_Equus_asinus.cs` |
| Environmental | `*_environmental_sample.cs` | DNA-only specimens |
| Unclassified | `unclassified_*/` folders | Taxonomically uncertain |

### Species Files (e.g., `Canis_lupus.cs`)

```csharp
/// <summary>
/// Species: Canis lupus
/// NCBI TaxId: 9612
/// </summary>
public class Canis_lupus : Canis
{
    public const bool IsEnriched = true;  // false = stub, true = has real data

    public string SpeciesName => "Canis lupus";
    public string CommonName => "Grey Wolf";
    public string ConservationStatus => "Least Concern";
    // ... more properties
}
```

### Genus Classes (e.g., `Canis.cs`)

```csharp
public abstract class Canis : Canidae, ICanis
{
    public override string TaxonomicRank => "genus";
    public virtual string GenusName => "Canis";
}
```

---

## 🔍 Key Fields in Species Files

**Stub species** (`IsEnriched = false`):

| Field | Description |
|-------|-------------|
| `IsEnriched` | `false` — placeholder data only |
| `SpeciesName` | Scientific binomial name |
| `CommonName` | English common name (may be `TODO: Enrich`) |
| `TaxonomicRank` | Always `"species"` |
| `TaxId` | NCBI Taxonomy ID |

**Enriched species** (`IsEnriched = true`) add:

| Field | Description |
|-------|-------------|
| `SpeciesCharacteristics` | `string[]` of distinctive features |
| `ConservationStatus` | IUCN Red List status |
| `AverageLifespanYears` | `double` |
| `ReproductionMethod` | e.g., "Viviparous" |
| `AdultLengthCm` | `(double Min, double Max)` tuple |

---

## 💡 Copilot Tips for This Repo

### 🧭 Breadcrumb Navigation (Recommended)

The repository uses **breadcrumb.md** files at key taxonomic levels for efficient navigation:

```
root/breadcrumb.md                          # Kingdom entry point
root/Metazoa/Chordata/Mammalia/breadcrumb.md   # All mammal orders
root/.../Carnivora/Canidae/breadcrumb.md    # Dog family genera & species
root/.../Canidae/Canis/breadcrumb.md        # Wolf genus with species list
```

**Each breadcrumb contains YAML frontmatter with:**
- `tags`: Flat array of searchable keywords (taxon name, rank, behaviors, conservation status)
- `related`: Paths to sibling/peer breadcrumbs for lateral navigation
- `links_from`: Backlinks showing which breadcrumbs reference this one
- `children`/`genera`: Sub-taxa with paths to their breadcrumbs
- `species`: Species list with conservation status, enrichment flag (genus level)

**Traversal depth guidance:**
| Depth | Use Case | Example |
|-------|----------|---------|
| 0 | Single lookup | "What is Canis lupus conservation status?" |
| 1 | Standard query (default) | "List all endangered Canidae" |
| 2 | Cross-cutting concern | "Compare pack behavior across Carnivora families" |

**Use breadcrumbs for:**
- Finding species: Read genus breadcrumb → find species in list → open file
- Conservation queries: Check `tags` for conservation keywords or `endangered_species`
- Behavior/habitat queries: Check `tags` for behavior/habitat keywords
- Tag-based discovery: Search breadcrumbs by tag intersection for multi-concept queries

**Skills:** 
- `.github/skills/breadcrumb-traversal/` — Traversal depth and tag-based discovery
- `.github/skills/breadcrumb-creation/` — Creating and maintaining breadcrumbs
- `.github/skills/species-lookup/` — Finding specific species

### Finding Species
- **Breadcrumb method**: Read genus breadcrumb.md → find species in `species` array
- Use file patterns: `**/Canidae/**/*.cs` or `**/*_lupus.cs`
- Grep for `TaxId: {id}` for exact species lookup
- **Glob patterns beat semantic search** for this structured codebase

### Understanding Hierarchy
- Each folder is a taxonomic rank
- Parent class is always in the parent folder
- Interfaces (I*.cs) define behaviors at each level
- **Breadcrumb parent links**: Each breadcrumb has `parent: "../breadcrumb.md"`
- **Backlinks**: Each breadcrumb has `links_from` showing what references it

### Working with Species Data
- Check `IsEnriched` to know if data is real or placeholder
- `TaxId` links to NCBI taxonomy database
- Conservation status follows IUCN categories (see reference below)

---

## 🔍 Search Strategies

Best practices for navigating 161K files:

| Task | Efficient Approach | Avoid |
|------|-------------------|-------|
| Find specific species | Read genus `breadcrumb.md` → species list | Scanning folder |
| List species in genus | Read `breadcrumb.md` → `species` array | `ls *.cs` on folder |
| Find endangered species | Check family breadcrumb `endangered_species` | Grep across files |
| Find by habitat/behavior | Check breadcrumb `tags.habitat` or `tags.behavior` | Reading each file |
| Understand inheritance | Read genus file only (parent is documented) | Walking up folder tree |
| Check conservation status | Read breadcrumb species list OR single file | Listing all species |

### Tag-Based Discovery via Breadcrumbs

Breadcrumb files aggregate tags across their subtaxa:

```yaml
tags:
  conservation: ["endangered", "least-concern", "vulnerable"]
  behavior: ["pack-hunter", "social", "territorial"]
  habitat: ["arctic", "temperate", "forest"]
  diet: ["carnivore", "omnivore"]
```

**Query examples:**
- "Find pack animals" → Search breadcrumbs for `behavior: ["pack-hunter"]`
- "Find arctic species" → Search breadcrumbs for `habitat: ["arctic"]`
- "Find endangered canids" → Read `Canidae/breadcrumb.md` → `endangered_species` list

---

## ⚡ Context Efficiency

### Principles

1. **TaxId is your primary key** — unique, searchable, links to NCBI
2. **Patterns are deterministic** — namespace/class/parent derivable from path
3. **Species are self-contained** — no sibling dependencies
4. **~150 lines for full context** — species + genus + interface
5. **Glob > semantic search** — faster, more precise for this structure
6. **Sample, don't enumerate** — one species per family for patterns

### Context Budgeting

| File Type | Approx. Lines | When to Read |
|-----------|---------------|--------------|
| Species (stub) | 30–40 | Basic info |
| Species (enriched) | 60–100 | Full details |
| Genus class | 30–50 | Inheritance context |
| Interface | 20–40 | Contract reference |
| **Full context** | ~150 max | species + genus + interface |

### Predictable Patterns (avoid lookups)

These are **deterministic** — derive from path, don't read files:

| Pattern | Rule |
|---------|------|
| Namespace | `AnimalKingdom.` + folder path (dots for slashes) |
| Class name | Same as filename minus `.cs` |
| Parent class | Folder name one level up |
| Interface name | `I` + class name |

### Self-Contained Files

Species files have **no cross-species dependencies**:
- Species only inherits from genus (one file)
- No imports from sibling species
- No shared utilities to track down
- **Safe to read in isolation**

---

## 🚫 Anti-Patterns

Critical for context preservation:

- ❌ **Never list entire genus folders** — some have 500+ species files
- ❌ **Never semantic search without constraints** — 161K files will overwhelm
- ❌ **Never build inheritance tree dynamically** — it's static and documented
- ❌ **Never read sibling species** unless explicitly comparing them

---

## 📊 Sampling Strategy

When analyzing patterns across many files:
1. Pick **one representative per family** (not all species)
2. Use enriched species over stubs for richer data
3. Target major families as canonical examples: `Canidae`, `Felidae`, `Ursidae`

---

## 📚 Static Reference Data

### IUCN Conservation Status Codes

| Code | Status |
|------|--------|
| LC | Least Concern |
| NT | Near Threatened |
| VU | Vulnerable |
| EN | Endangered |
| CR | Critically Endangered |
| EW | Extinct in Wild |
| EX | Extinct |

### Taxonomic Rank Hierarchy

```
Kingdom → Phylum → Class → Order → Family → Genus → Species
```

---

## ⚠️ Known Data Quirks

| Quirk | Details |
|-------|---------|
| Templated data | Some family names say "Canidae" generically |
| Environmental samples | Lack most biological properties |
| AI-generated | Enrichment data should be verified externally |

---

## 🚫 What's NOT in This Repo

- ❌ No unit tests
- ❌ No solution file (`.sln`)
- ❌ No shared utilities outside `root/`
- ❌ No runtime/executable — reference-only codebase

---

## 🔗 Related Repository

This code was generated by the **Animal Kingdom Generator**:
https://github.com/rmathis/AnimalKingdomGenerator

The generator uses NCBI taxonomy data + Wikidata + AI enrichment.

---

## 🛠️ Note: Copilot CLI

**"Copilot CLI"** refers to the new agentic terminal tool (public preview) that can read/write files, run commands, and connect to MCP servers — **not** the older `gh copilot explain/suggest` commands.

**Non-interactive usage:**
```bash
copilot -p "YOUR PROMPT HERE"     # Full output
copilot -sp "YOUR PROMPT HERE"    # Silent (response only)
```

Details: https://github.com/features/copilot/cli/
Docs: https://docs.github.com/en/copilot/how-tos/copilot-cli/cli-getting-started
