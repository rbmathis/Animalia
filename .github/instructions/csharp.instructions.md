---
applyTo: "**/*.cs"
---

# C# File Instructions (All .cs Files)

General instructions for all C# files in this taxonomy codebase.

## Namespace Convention

Namespaces mirror folder paths exactly:
```
Path:      root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/
Namespace: AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis
```

**Derive namespace from path** — don't search for it.

## File Types by Pattern

| Pattern | Type | Example |
|---------|------|---------|
| `{Taxon}.cs` | Base class | `Canidae.cs`, `Canis.cs` |
| `I{Taxon}.cs` | Interface | `ICanidae.cs`, `ICanis.cs` |
| `Genus_species.cs` | Species | `Canis_lupus.cs` |
| `*_x_*.cs` | Hybrid | `Canis_latrans_x_Canis_lupus.cs` |
| `*_environmental_sample.cs` | Environmental sample | `Canis_environmental_sample.cs` |

## Inheritance Hierarchy

```
IAnimal (root)
    ↓
Chordata (phylum)
    ↓
Mammalia (class)
    ↓
Carnivora (order)
    ↓
Canidae (family) : ICanidae
    ↓
Canis (genus) : Canidae, ICanis
    ↓
Canis_lupus (species) : Canis
```

**To find parent class**: Go up one folder level — class name matches folder name.

## Path Derivation Rules

From any `.cs` file path, derive:

| Target | Rule |
|--------|------|
| Parent class | Folder one level up, same name as that folder |
| Grandparent | Two folders up |
| Interface | Same folder, prepend `I` |
| Namespace | Replace `/` with `.`, prepend `AnimalKingdom` |
| Siblings | Other `.cs` files in same folder |
| Breadcrumb | Same folder, `breadcrumb.md` |

## Key Properties (Common to All Taxa)

| Property | Description |
|----------|-------------|
| `ScientificName` | Taxonomic name |
| `TaxonomicRank` | kingdom, phylum, class, order, family, genus, species |
| `TaxId` | NCBI Taxonomy ID (unique primary key) |

## Context Efficiency

- Read **~150 lines** for full context: species + genus + interface
- Use **glob patterns** before reading files
- **Sample one species per family** to understand patterns
- **TaxId** is the unique identifier linking to NCBI Taxonomy
