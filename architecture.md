# Animalia Repository Architecture

This document provides a reference guide for navigating and understanding the Animal Kingdom taxonomy codebase.

## 📊 Repository Overview

| Metric | Value |
|--------|-------|
| **Total Files** | 161,663 |
| **Lines of Code** | 1.6M |
| **Size** | 123.6 MB |
| **C# Files** | 146,082 |
| **Folder Depth** | 7–12 levels |
| **Major Taxonomic Units** | Kingdom → Phylum → Class → Order → Family → Genus → Species |

**Note**: No solution file (`.sln`). Each folder contains its own `.csproj`.

---

## 🗂️ Directory Structure

### Taxonomy Hierarchy

```
root/
└── Metazoa/ (Phylum)
    └── Chordata/ (Phylum)
        └── Mammalia/ (Class)
            ├── Carnivora/ (Order)
            │   ├── Canidae/ (Family)
            │   │   ├── Canis/ (Genus)
            │   │   │   ├── Canis_lupus.cs (Species: Grey Wolf)
            │   │   │   └── Canis_latrans.cs (Species: Coyote)
            │   │   ├── Felidae/ (Family)
            │   │   └── Ursidae/ (Family)
            ├── Primates/ (Order)
            └── Cetacea/ (Order)
```

### Namespace Convention

Namespaces **mirror folder paths exactly**:

```
AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis
```

Derive the namespace from the path—don't look it up elsewhere.

---

## 📁 File Organization Patterns

### By Rank Level

Each taxonomic rank contains:

| File Type | Example | Purpose |
|-----------|---------|---------|
| **Base Class** | `Canidae.cs` | Extends parent rank (Family extends Order) |
| **Interface** | `ICanidae.cs` | Defines properties & contracts for rank |
| **Breadcrumb** | `breadcrumb.md` | YAML metadata + navigation for rank |
| **Project** | `Canidae.csproj` | MSBuild configuration |

### Species Files

#### Naming Patterns

| Type | Pattern | Example |
|------|---------|---------|
| Regular species | `Genus_species.cs` | `Canis_lupus.cs` |
| Hybrid | `Genus_species_x_Genus_species.cs` | `Equus_caballus_x_Equus_asinus.cs` |
| Environmental sample | `*_environmental_sample.cs` | Species DNA with minimal metadata |
| Unclassified | Inside `unclassified_*/` folders | Taxonomically uncertain specimens |

#### Data Enrichment Status

```csharp
public class Canis_lupus : Canis
{
    public const bool IsEnriched = true;  // false = stub, true = has real data
    
    // Stub species (IsEnriched = false) have only:
    public string SpeciesName => "Canis lupus";
    public string CommonName => "Grey Wolf";
    public int TaxId => 16693;
    
    // Enriched species (IsEnriched = true) add:
    public string ConservationStatus => "Least Concern";
    public double AverageLifespanYears => 13.0;
    public (double Min, double Max) AdultLengthCm => (130, 150);
    public string[] SpeciesCharacteristics => new[] { "pack hunter", "territorial" };
}
```

---

## 🧭 Navigation Strategies

### 1. Breadcrumb Files (Recommended)

**Breadcrumbs are the most efficient entry point** for large taxonomic levels.

**Location Pattern**: `root/.../[Rank]/breadcrumb.md`

**Metadata Structure** (YAML frontmatter):

```yaml
---
title: "Canidae (Dog Family)"
description: "Family containing 15 genera"
category: "taxonomy/family"
tags: ["canidae", "family", "carnivore", "pack-hunter", "non-retractable-claws"]
status: "Living"
rank: "family"
taxId: 9608
parent: "../breadcrumb.md"
related: ["../Ailuridae/breadcrumb.md", "../Felidae/breadcrumb.md", "../Ursidae/breadcrumb.md"]
links_from: ["../Carnivora/breadcrumb.md"]
children_count: 15
species_count: 0
characteristics:
  - "Long muzzle"
  - "Non-retractable claws"
  - "Digitigrade stance"
  - "Bushy tail"
genera:
  - name: "Canis"
    path: "Canis/breadcrumb.md"
  - name: "Vulpes"
    path: "Vulpes/breadcrumb.md"
endangered_species: []
---
```

**Key Fields for Navigation**:

| Field | Use Case |
|-------|----------|
| `tags` | Keyword search (behavior, habitat, conservation status) |
| `related` | Find sibling taxa (other families in same order) |
| `parent` | Navigate up one rank |
| `links_from` | See what references this breadcrumb |
| `genera` / `children` | List direct children with paths |
| `species` | Species array with conservation status & enrichment flag |
| `endangered_species` | Quick lookup of threatened species |

**Traversal Depth Guidance**:

| Depth | Use Case | Example Query |
|-------|----------|---------|
| **0** | Single lookup | "Get Canis lupus conservation status" → Read genus breadcrumb, find species |
| **1** | Standard navigation (default) | "List all endangered dogs" → Read family breadcrumb → check `endangered_species` |
| **2** | Cross-cutting concern | "Compare pack behavior across Carnivora" → Read order breadcrumb → traverse 2 levels |

### 2. File Search

#### Glob Patterns (Fast & Precise)

Use glob patterns to narrow search scope **before reading files**:

```powershell
# Find all wolves in Canis genus
glob "**/Canis/*_lupus.cs"

# Find all Felidae (cat family) species
glob "**/Felidae/**/*.cs"

# Find all species with "bear" in name
glob "**/*bear*.cs"
```

#### Grep Search (Content)

Search file contents for specific properties:

```powershell
# Find species by NCBI TaxId
grep -r "TaxId = 16693" root/

# Find enriched species in Carnivora order
grep -r "IsEnriched = true" root/Metazoa/Chordata/Mammalia/Carnivora/

# Find species by conservation status
grep -r "ConservationStatus.*Endangered" root/
```

#### By TaxId (Unique Identifier)

TaxIds are **primary keys** linking to NCBI Taxonomy:

```powershell
# Find species by NCBI TaxId
grep -r "const int TaxId = 16693" root/
```

### 3. Class Hierarchy Navigation

**Inheritance is static and predictable** — no dynamic construction:

```
                    IAnimal
                       ↑
                   Chordata
                       ↑
                   Mammalia
                       ↑
                   Carnivora
                       ↑
                     Canidae  (ICanidae)
                       ↑
                     Canis    (ICanis)
                       ↑
                   Canis_lupus
```

**To find parent**: Go up one folder level — same class name as folder.

---

## 🔍 Efficient Search Strategies

### Task: Find a Specific Species

**Fastest approach**:
1. Identify the genus folder (use glob or breadcrumb)
2. Read genus breadcrumb.md → find species in `species` array
3. Open the species file

**Example**: Find Grey Wolf conservation status
```
root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/breadcrumb.md
→ species array contains Canis_lupus with conservation: "Least Concern"
```

### Task: List All Species in a Family

**Use breadcrumb, not filesystem listing** (prevents scanning 500+ files):
1. Read `root/.../[Family]/breadcrumb.md`
2. Extract `genera` array → get list of genera with paths
3. For species in genus: Read genus breadcrumb → `species` array

### Task: Find Species by Conservation Status

**Search breadcrumbs by tag or use grep**:
```powershell
# Via breadcrumb tags
grep -r "endangered" root/**/breadcrumb.md

# Via species files
grep -r "ConservationStatus.*EN\|Endangered" root/
```

### Task: Find Species by Habitat or Behavior

**Use breadcrumb tags** (aggregated across subtaxa):
1. Read family/order breadcrumb
2. Check `tags.habitat` or `tags.behavior` arrays
3. Navigate to child breadcrumbs matching criteria

### Task: Understand Class Inheritance

**Read three files only**:
1. Species file → extends parent class
2. Genus file → extends family, implements IGenus
3. Genus interface → defines behaviors

No need to traverse up entire hierarchy.

---

## 📊 Data Quality Reference

### IsEnriched Flag

```csharp
IsEnriched = false  // Stub data: minimal properties
IsEnriched = true   // Enriched: full biological data
```

**Stub fields**:
- `SpeciesName`, `CommonName`, `TaxId`, `TaxonomicRank`

**Enriched fields** (add to stubs):
- `ConservationStatus` (IUCN code: LC, VU, EN, CR, EX)
- `AverageLifespanYears` (double)
- `ReproductionMethod` (string: "Viviparous", "Oviparous", etc.)
- `AdultLengthCm` (tuple: Min, Max)
- `SpeciesCharacteristics` (string array)
- `Habitat`, `Diet`, `Behavior` (varies by species)

### IUCN Conservation Status Codes

| Code | Status | Risk Level |
|------|--------|-----------|
| **EX** | Extinct | 💀 |
| **EW** | Extinct in Wild | 💀 |
| **CR** | Critically Endangered | 🔴 |
| **EN** | Endangered | 🟠 |
| **VU** | Vulnerable | 🟡 |
| **NT** | Near Threatened | 🟡 |
| **LC** | Least Concern | 🟢 |

---

## 🚫 Anti-Patterns (Avoid These)

| ❌ Anti-Pattern | ✅ Instead |
|-----------------|-----------|
| List entire genus folder (500+ species) | Read genus breadcrumb → `species` array |
| Semantic search without constraints | Use glob patterns + breadcrumb tags |
| Read every sibling species | Sample one per family + use breadcrumb aggregates |
| Walk up folder tree for inheritance | Read current file + parent genus file only |
| Search all 161K files for a property | Use glob to narrow scope first |

---

## 🎯 Quick Reference: Common Queries

### "How many genera in Canidae?"
→ Read `root/.../Canidae/breadcrumb.md` → count `genera` array

### "Is the Grey Wolf endangered?"
→ Read `root/.../Canis/breadcrumb.md` → find Canis_lupus in `species` array → check conservation status

### "What families are related to Canidae?"
→ Read `root/.../Canidae/breadcrumb.md` → check `related` field

### "Find all critically endangered cats"
→ Read `root/.../Felidae/breadcrumb.md` → check `endangered_species` list

### "What's the parent order of Canidae?"
→ From path `root/.../Carnivora/Canidae/` → parent is Carnivora, or read breadcrumb → `parent` field

### "Find all swimming animals"
→ Grep breadcrumb tags: `grep -r "swim\|aquatic\|marine" root/**/breadcrumb.md`

---

## 🗂️ File Structure Summary

```
root/
├── architecture.md (this file)
├── README.md
├── breadcrumb.md (Kingdom entry point)
├── scenarios.json
├── scenarios.md
├── todo.md
├── guide/
├── results/
└── Metazoa/
    └── Chordata/
        ├── breadcrumb.md
        ├── Mammalia/
        │   ├── breadcrumb.md
        │   ├── Carnivora/
        │   │   ├── breadcrumb.md
        │   │   ├── Canidae/
        │   │   │   ├── breadcrumb.md
        │   │   │   ├── Canidae.cs
        │   │   │   ├── ICanidae.cs
        │   │   │   ├── Canidae.csproj
        │   │   │   ├── Canis/
        │   │   │   │   ├── breadcrumb.md
        │   │   │   │   ├── Canis.cs
        │   │   │   │   ├── ICanis.cs
        │   │   │   │   ├── Canis_lupus.cs
        │   │   │   │   ├── Canis_latrans.cs
        │   │   │   │   └── ...
        │   │   │   └── Vulpes/
        │   │   │       └── ...
        │   │   ├── Felidae/
        │   │   └── ...
        │   └── Primates/
        │       └── ...
        └── Aves/
            └── ...
```

---

## 🔗 Related Resources

- **NCBI Taxonomy**: https://www.ncbi.nlm.nih.gov/taxonomy — TaxIds are resolvable here
- **Animal Kingdom Generator**: https://github.com/rmathis/AnimalKingdomGenerator — Source of this data
- **Wikidata**: Used for enrichment data validation

---

## 📝 Document Metadata

- **Version**: 1.0
- **Last Updated**: 2026-02-23
- **Audience**: Developers, AI assistants (Copilot CLI, IDE tools)
- **Purpose**: Navigation guide for 161K+ file codebase
