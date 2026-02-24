---
applyTo: "**/*_*.cs"
---

# Species File Instructions

This file matches **species classes** (files with underscore in name, e.g., `Canis_lupus.cs`).

## File Structure

Species files follow this pattern:
- **Naming**: `Genus_species.cs` (e.g., `Canis_lupus.cs`)
- **Hybrids**: `Genus_species_x_Genus_species.cs`
- **Namespace**: Derived from path (e.g., `AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis`)
- **Inheritance**: Extends genus class (e.g., `Canis_lupus : Canis`)

## Key Properties

| Property | Type | Description |
|----------|------|-------------|
| `IsEnriched` | `const bool` | `true` = full data, `false` = stub |
| `SpeciesName` | `string` | Scientific name (e.g., "Canis lupus") |
| `CommonName` | `string` | Common name (e.g., "timber wolf") |
| `TaxId` | `int` | NCBI Taxonomy ID (unique primary key) |
| `TaxonomicRank` | `string` | Always "species" |
| `ConservationStatus` | `string` | IUCN code: LC, NT, VU, EN, CR, EW, EX |
| `SpeciesCharacteristics` | `string[]` | Distinctive features |
| `AverageLifespanYears` | `double` | Lifespan in years |
| `ReproductionMethod` | `string` | "Viviparous", "Oviparous", etc. |

## Navigation Rules

- **Parent class**: Same folder, genus name (e.g., `Canis.cs`)
- **Parent interface**: Same folder, prepend `I` (e.g., `ICanis.cs`)
- **Siblings**: Other `Genus_*.cs` files in same folder
- **Breadcrumb**: Same folder, `breadcrumb.md` (contains species array with conservation status)

## IUCN Conservation Status Codes

- **EX** = Extinct | **EW** = Extinct in Wild
- **CR** = Critically Endangered | **EN** = Endangered
- **VU** = Vulnerable | **NT** = Near Threatened | **LC** = Least Concern

## Editing Guidelines

- Maintain `IsEnriched` flag accuracy
- Use valid IUCN codes for `ConservationStatus`
- Keep `TaxId` unchanged (primary key)
- Follow XML doc comment style for all properties
