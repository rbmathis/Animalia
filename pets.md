# Pet Species Lookup Feature

This document describes the pet species lookup feature for the Animal Kingdom repository, enabling efficient discovery of commonly kept pets without file scanning.

---

## Overview

The pet lookup feature uses **breadcrumb metadata** to quickly find species commonly kept as pets. Instead of scanning 160K+ files, Copilot can:

1. Grep breadcrumbs for `has-pets` tag
2. Read matching breadcrumbs
3. Extract `pet_species` arrays

**Result**: Pet queries answered in seconds, not minutes.

---

## Pet Species in Repository

| Common Name | Scientific Name | Family | Order |
|-------------|-----------------|--------|-------|
| Domestic Cat | *Felis catus* | Felidae | Carnivora |
| Dog | *Canis lupus* | Canidae | Carnivora |
| Ferret | *Mustela putorius* | Mustelidae | Carnivora |
| European Rabbit | *Oryctolagus cuniculus* | Leporidae | Lagomorpha |
| Guinea Pig | *Cavia porcellus* | Caviidae | Rodentia |
| Golden Hamster | *Mesocricetus auratus* | Cricetidae | Rodentia |
| Chinchilla | *Chinchilla lanigera* | Chinchillidae | Rodentia |
| Goldfish | *Carassius auratus* | Cyprinidae | Cypriniformes |
| Budgerigar | *Melopsittacus undulatus* | Psittaculidae | Psittaciformes |

---

## Schema

Pet information is stored at multiple taxonomy levels in breadcrumb files:

### Species Entry (in genus breadcrumb)

```yaml
species:
  - file: "Felis_catus.cs"
    name: "Felis catus"
    common_name: "Domestic Cat"
    conservation: "Domesticated"
    enriched: true
    pet: true                    # ← Pet flag
```

### Genus Level

```yaml
tags: ["felis", "genus", "has-pets"]   # ← has-pets tag
pet_species:
  - file: "Felis_catus.cs"
    name: "Felis catus"
    common_name: "Domestic Cat"
```

### Family Level

```yaml
tags: ["felidae", "family", "has-pets"]
pet_genera:
  - name: "Felis"
    path: "Felis/breadcrumb.md"
```

### Order+ Level

```yaml
tags: ["carnivora", "order", "has-pets"]
pet_families:
  - name: "Felidae"
    path: "Felidae/breadcrumb.md"
  - name: "Canidae"
    path: "Canidae/breadcrumb.md"
```

---

## Usage

### Find All Pet Species

```bash
# Find all taxa containing pets
grep "has-pets" root/**/breadcrumb.md

# Find pet mammals only
grep "has-pets" root/**/Mammalia/**/breadcrumb.md
```

### Find Pets in a Specific Family

```bash
# Read family breadcrumb → check pet_genera
cat root/Metazoa/Chordata/Mammalia/Carnivora/Felidae/breadcrumb.md
```

### Check if a Species is a Pet

```bash
# Read genus breadcrumb → find species → check pet: true
cat root/Metazoa/Chordata/Mammalia/Carnivora/Felidae/Felis/breadcrumb.md
```

---

## Test Results

Ran pet lookup queries using breadcrumb navigation:

| Query | Method | Files Read | Time |
|-------|--------|-----------|------|
| "Find all pet mammals" | `grep "has-pets"` | 14 breadcrumbs | <1s |
| "Is Felis catus a pet?" | Read genus breadcrumb | 1 file | <1s |
| "Pet families in Carnivora" | Read order breadcrumb | 1 file | <1s |

### Breadcrumbs Updated

14 breadcrumb files now contain pet metadata:

**Genus level (7):**
- `Canis/breadcrumb.md`
- `Felis/breadcrumb.md`
- `Mustela/breadcrumb.md`
- `Oryctolagus/breadcrumb.md`
- `Cavia/breadcrumb.md`
- `Chinchilla/breadcrumb.md`
- `Mesocricetus/breadcrumb.md`

**Family level (7):**
- `Canidae/breadcrumb.md`
- `Felidae/breadcrumb.md`
- `Mustelidae/breadcrumb.md`
- `Leporidae/breadcrumb.md`
- `Caviidae/breadcrumb.md`
- `Chinchillidae/breadcrumb.md`
- `Cricetidae/breadcrumb.md`

---

## Apartment-Friendly Pets

Based on the pet data, here are recommendations for apartment living:

| Pet | Why Good for Apartments |
|-----|-------------------------|
| **Guinea Pig** | Quiet, gentle, social, no outdoor needs |
| **Golden Hamster** | Small cage, low maintenance |
| **European Rabbit** | Can be litter-trained, quiet |
| **Chinchilla** | No odor, long-lived (15+ years) |
| **Domestic Cat** | Indoor-friendly, independent |

### Top Pick: Guinea Pig (*Cavia porcellus*)

- Very gentle and rarely bite — great for kids
- Make happy "wheek" sounds (not barking/meowing)
- Don't need outdoor walks
- Social — enjoy being handled
- Moderate lifespan (5-7 years)

---

## Implementation Files

| File | Purpose |
|------|---------|
| [.github/skills/pet-lookup/SKILL.md](.github/skills/pet-lookup/SKILL.md) | Copilot skill for pet lookups |
| [.github/instructions/breadcrumb.instructions.md](.github/instructions/breadcrumb.instructions.md) | Pet schema documentation |
| [add-pet-data.ps1](add-pet-data.ps1) | Script to seed pet data into breadcrumbs |

---

## Adding New Pet Species

To add a new pet species:

1. Edit `add-pet-data.ps1` — add entry to `$PetSpecies` array
2. Run `.\add-pet-data.ps1` to update breadcrumbs
3. Verify with `grep "has-pets" root/**/breadcrumb.md`

Example entry:

```powershell
@{
    File = "Betta_splendens.cs"
    Name = "Betta splendens"
    CommonName = "Siamese Fighting Fish"
    GenusPath = "root/Metazoa/Chordata/Actinopteri/Anabantiformes/Osphronemidae/Betta"
    Family = "Osphronemidae"
    Order = "Anabantiformes"
}
```

---

## Anti-Patterns

❌ **Don't** grep `.cs` files for "pet" or "domestic"
❌ **Don't** scan species files looking for pet indicators
❌ **Don't** use semantic search for "pet species"

✅ **Do** use `has-pets` tag in breadcrumbs
✅ **Do** read `pet_species` arrays from genus breadcrumbs
✅ **Do** check `pet_genera` in family breadcrumbs
