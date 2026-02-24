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

**See [`architecture.md`](../../architecture.md) for complete structure, file patterns, and namespace conventions.**

Quick overview:
```
Animalia/
└── root/
    └── Metazoa/
        └── Chordata/
            └── Mammalia/
                └── Carnivora/
                    └── Canidae/
                        └── Canis/
                            ├── Canis.cs (Genus class)
                            ├── Canis_lupus.cs (Species)
                            └── breadcrumb.md
```

---

## 🧬 File Patterns & Species Data

**See [`architecture.md`](../../architecture.md) for detailed file patterns, enrichment reference, and data structure.**

Quick reference:
- **Species file naming**: `Genus_species.cs` (e.g., `Canis_lupus.cs`)
- **Hybrids**: `Genus_species_x_Genus_species.cs`
- **Enrichment flag**: `IsEnriched` (true = full data, false = stub)
- **Primary key**: `TaxId` (NCBI Taxonomy ID)

---

## 💡 Copilot Tips for This Repo

### 🧭 Breadcrumb Navigation (Recommended)

**See [`architecture.md`](../../architecture.md) for comprehensive navigation strategies.**

Quick summary:
- Read breadcrumb.md files at taxonomy levels for efficient navigation
- Use breadcrumb `tags` for searching by behavior, habitat, conservation status
- Use `related` field to find sibling families
- Use `species` array in genus breadcrumbs to list species
- Traversal depth: 0 (single lookup) → 1 (standard) → 2 (cross-cutting)

---

## 🔍 Search Strategies

**See [`architecture.md`](../../architecture.md) for complete search strategies and quick reference queries.**

Key approaches:
- **Breadcrumb tags**: Search breadcrumbs for conservation status, behavior, habitat
- **Glob patterns**: `**/Canidae/**/*.cs` to narrow file scope
- **Grep by TaxId**: `grep -r "TaxId = 9612" root/`
- **Avoid**: Listing 500+ species files, semantic search without constraints

---

## ⚡ Context Efficiency

**See [`architecture.md`](../../architecture.md) for context budgeting, anti-patterns, and efficiency principles.**

Core principles:
- **TaxId** is the primary key (unique, links to NCBI)
- **~150 lines** for full context (species + genus + interface)
- **Glob > semantic search** for this structured codebase
- **Sample, don't enumerate** (one species per family for patterns)
- **Patterns are deterministic** — derive namespace/class/parent from path

---

## �️ Path Formulas (Construct, Don't Search)

Paths are deterministic—**construct them directly** instead of searching.

### Build Paths from Species Name

Given a species like `Canis_lupus` in family `Canidae`:

| Target | Path Pattern |
|--------|--------------|
| Species file | `root/**/Canidae/Canis/Canis_lupus.cs` |
| Genus class | `root/**/Canidae/Canis/Canis.cs` |
| Genus interface | `root/**/Canidae/Canis/ICanis.cs` |
| Genus breadcrumb | `root/**/Canidae/Canis/breadcrumb.md` |
| Family breadcrumb | `root/**/Canidae/breadcrumb.md` |

### Derive from Any File Path

From path `root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/Canis_lupus.cs`:

| Derivation | Result |
|------------|--------|
| **Parent class** | Folder name one level up → `Canis` (in `../Canis.cs`) |
| **Grandparent** | Two levels up → `Canidae` (in `../../Canidae.cs`) |
| **Namespace** | Replace `/` with `.` → `AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis` |
| **Interface** | Same folder, prepend `I` → `ICanis.cs` |
| **Siblings** | Other `Canis_*.cs` files in same folder |
| **Cousins** | Other genus folders in `../` (e.g., `Vulpes/`, `Lycaon/`) |

### Glob Pattern Templates

| Task | Glob Pattern |
|------|--------------|
| All species in a genus | `**/Canis/Canis_*.cs` |
| All genera in a family | `**/Canidae/*/` (directories) |
| All interfaces in a family | `**/Canidae/**/I*.cs` |
| All breadcrumbs in an order | `**/Carnivora/**/breadcrumb.md` |
| All species in a family | `**/Canidae/**/*_*.cs` |

### Scoped Grep Examples

Narrow grep searches using path prefixes:

```bash
# Only Canidae family
grep "ConservationStatus" root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/**/*.cs

# Only one genus
grep "IsEnriched" root/**/Canis/*.cs

# All breadcrumbs in Carnivora
grep "endangered" root/**/Carnivora/**/breadcrumb.md
```

### Sibling Navigation

- **Related families**: Same parent folder (e.g., `Canidae/` and `Felidae/` are siblings under `Carnivora/`)
- **Related genera**: Same family folder (e.g., `Canis/` and `Vulpes/` under `Canidae/`)
- **Related species**: Same genus folder

---

## �📚 Reference Data

**See [`architecture.md`](../../architecture.md) for complete reference section.**

Quick lookup:

**IUCN Conservation Status:**
- EX = Extinct | EW = Extinct in Wild | CR = Critically Endangered | EN = Endangered
- VU = Vulnerable | NT = Near Threatened | LC = Least Concern

**Taxonomic Hierarchy:**
Kingdom → Phylum → Class → Order → Family → Genus → Species

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
