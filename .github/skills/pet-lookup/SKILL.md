---
name: pet-lookup
description: Find species commonly kept as pets in the Animal Kingdom repository. Use when looking for pet species, domestic animals, or companion animals. Triggered by "find pets", "pet species", "domestic animals", "companion animals", "commonly kept as pets".
metadata:
  author: animal-kingdom
  version: "1.0"
---

# Pet Species Lookup

Find commonly kept pet species **without file scanning** by using breadcrumb metadata.

## When to Use

- Looking for species commonly kept as pets
- Finding domestic or companion animals
- Comparing pet species across families/orders
- Checking if a specific species is a common pet

## Pet Data in Breadcrumbs

Pet information is aggregated at multiple taxonomy levels:

### Species Level (in genus breadcrumb `species` array)
```yaml
species:
  - file: "Canis_lupus_familiaris.cs"
    name: "Canis lupus familiaris"
    common_name: "Domestic Dog"
    pet: true                    # Boolean flag
```

### Genus Level
```yaml
tags: ["canis", "genus", "has-pets"]
pet_species:
  - file: "Canis_lupus_familiaris.cs"
    name: "Canis lupus familiaris"
    common_name: "Domestic Dog"
```

### Family Level
```yaml
tags: ["canidae", "family", "has-pets"]
pet_genera:
  - name: "Canis"
    path: "Canis/breadcrumb.md"
```

### Order+ Level
```yaml
tags: ["carnivora", "order", "has-pets"]
pet_families:
  - name: "Canidae"
    path: "Canidae/breadcrumb.md"
  - name: "Felidae"
    path: "Felidae/breadcrumb.md"
```

## Lookup Strategies

### Strategy 1: Find All Pets in a Taxonomic Group

Use `has-pets` tag to quickly identify taxa containing pets:

```bash
# Find all pet-containing taxa in Mammalia
grep "has-pets" root/**/Mammalia/**/breadcrumb.md

# Find pet-containing families in Carnivora
grep "has-pets" root/**/Carnivora/*/breadcrumb.md
```

### Strategy 2: List Pet Species in a Genus

Read the genus breadcrumb and check `pet_species` array:

```
root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/breadcrumb.md
→ pet_species array lists all pet species
```

### Strategy 3: Find Pet Families in an Order

Read the order breadcrumb and check `pet_families` array:

```
root/Metazoa/Chordata/Mammalia/Carnivora/breadcrumb.md
→ pet_families array lists families with pets
```

### Strategy 4: Check if Specific Species is a Pet

1. Navigate to genus breadcrumb
2. Find species in `species` array
3. Check `pet: true` flag

## Common Pet Species (Reference)

| Common Name | Scientific Name | Family |
|-------------|-----------------|--------|
| Domestic Dog | Canis lupus familiaris | Canidae |
| Domestic Cat | Felis catus | Felidae |
| Golden Hamster | Mesocricetus auratus | Cricetidae |
| Guinea Pig | Cavia porcellus | Caviidae |
| Domestic Rabbit | Oryctolagus cuniculus | Leporidae |
| Goldfish | Carassius auratus | Cyprinidae |
| Budgerigar | Melopsittacus undulatus | Psittaculidae |
| Ferret | Mustela putorius furo | Mustelidae |
| Gerbil | Meriones unguiculatus | Muridae |
| Chinchilla | Chinchilla lanigera | Chinchillidae |

## Example Queries

| Query | Method |
|-------|--------|
| "Find pet dogs" | Read `Canis/breadcrumb.md` → `pet_species` |
| "Which Carnivora are pets?" | Read `Carnivora/breadcrumb.md` → `pet_families` |
| "Find all pet mammals" | `grep "has-pets" root/**/Mammalia/**/breadcrumb.md` |
| "Is Felis catus a pet?" | Read `Felis/breadcrumb.md` → check species array for `pet: true` |
| "List pet rodents" | Read `Rodentia/breadcrumb.md` → `pet_families` |

## Anti-Patterns

- ❌ Grepping `.cs` files for "pet" or "domestic"
- ❌ Scanning all species files looking for pet indicators
- ❌ Using semantic search for "pet species"
- ❌ Listing directories to find pet-related taxa

## Traversal Depth

| Query Type | Depth | Start Point |
|------------|-------|-------------|
| "Is X a pet?" | 0 | Genus breadcrumb |
| "Pets in family Y" | 1 | Family breadcrumb |
| "All pet mammals" | 2 | Class breadcrumb + grep |
