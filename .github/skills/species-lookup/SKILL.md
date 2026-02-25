---
name: species-lookup
description: Find specific species in the Animal Kingdom repository by scientific name, common name, or NCBI TaxId. Use when looking up a single species or comparing species properties like conservation status, lifespan, or characteristics.
metadata:
  author: animal-kingdom
  version: "1.0"
---

# Species Lookup

Quickly find specific species in the Animal Kingdom repository without scanning 160K files.

## When to Use

- Looking up a specific species by scientific name (e.g., "Canis lupus")
- Looking up a species by common name (e.g., "Grey Wolf")
- Finding species by NCBI TaxId
- Getting species properties (conservation status, lifespan, characteristics)

## Lookup Strategies

### Strategy 1: Scientific Name → File Path (Fastest)

Species files follow a predictable naming pattern:

```
{Genus}_{species}.cs
```

**Example:** "Canis lupus" → `Canis_lupus.cs`

Path formula:
```
root/Metazoa/Chordata/{Class}/{Order}/{Family}/{Genus}/{Genus}_{species}.cs
```

For well-known species, the path is deterministic:
- **Canis lupus** → `root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/Canis_lupus.cs`
- **Panthera leo** → `root/Metazoa/Chordata/Mammalia/Carnivora/Felidae/Panthera/Panthera_leo.cs`
- **Ursus arctos** → `root/Metazoa/Chordata/Mammalia/Carnivora/Ursidae/Ursus/Ursus_arctos.cs`

### Strategy 2: Genus Breadcrumb → Species Lookup

When you know the genus but not the exact species:

1. Navigate to genus breadcrumb: `{Family}/{Genus}/breadcrumb.md`
2. Read the `species_data` lookup table in frontmatter
3. Each key is the file stem, values include: `common_name`, `conservation` (IUCN code), `pet`

**Example:** Find wolves

```yaml
# From Canis/breadcrumb.md
species_data:
  Canis_lupus:
    common_name: timber wolf
    conservation: LC
    pet: true
  Canis_latrans:
    common_name: prairie wolf
    conservation: LC
```

**Derivation from key:**
- File: `{key}.cs` → `Canis_lupus.cs`
- Name: `{key}` with `_` → ` ` → `Canis lupus`

### Strategy 3: Common Name → Breadcrumb Search

For common name lookups:

1. Start at the likely family breadcrumb
2. Search for `common_name` in the species arrays
3. Grep breadcrumb.md files: `grep -r "Grey Wolf" **/breadcrumb.md`

### Strategy 4: TaxId Lookup

For NCBI TaxId:

```bash
grep -r "TaxId => 9612" root/**/*.cs
```

This returns `Canis_lupus.cs` (TaxId 9612).

## Quick Reference: Major Species Paths

| Species | Common Name | Path |
|---------|-------------|------|
| Canis lupus | Grey Wolf | `Carnivora/Canidae/Canis/Canis_lupus.cs` |
| Canis latrans | Coyote | `Carnivora/Canidae/Canis/Canis_latrans.cs` |
| Vulpes vulpes | Red Fox | `Carnivora/Canidae/Vulpes/Vulpes_vulpes.cs` |
| Panthera leo | Lion | `Carnivora/Felidae/Panthera/Panthera_leo.cs` |
| Panthera tigris | Tiger | `Carnivora/Felidae/Panthera/Panthera_tigris.cs` |
| Ursus arctos | Brown Bear | `Carnivora/Ursidae/Ursus/Ursus_arctos.cs` |
| Homo sapiens | Human | `Primates/Hominidae/Homo/Homo_sapiens.cs` |

All paths are relative to `root/Metazoa/Chordata/Mammalia/`.

## Species File Structure

Once you find the file, expect this structure:

```csharp
public class Canis_lupus : Canis
{
    public const bool IsEnriched = true;  // false = stub data

    public string SpeciesName => "Canis lupus";
    public string CommonName => "timber wolf";
    public override string TaxonomicRank => "species";
    public override int TaxId => 9612;

    public string[] SpeciesCharacteristics => new[] { ... };
    public string ConservationStatus => "Least Concern";
    public double AverageLifespanYears => 11.5;
    public string ReproductionMethod => "Viviparous";
}
```

## Key Fields

| Field | Description |
|-------|-------------|
| `IsEnriched` | `true` = full data, `false` = stub only |
| `TaxId` | NCBI Taxonomy ID |
| `ConservationStatus` | IUCN status (LC, NT, VU, EN, CR, EX) |
| `SpeciesCharacteristics` | Array of distinctive features |
| `AverageLifespanYears` | Typical lifespan |
| `ReproductionMethod` | Viviparous, Oviparous, etc. |

## Efficiency Tips

1. **Use glob patterns**: `**/Canis_lupus.cs` finds the file directly
2. **Breadcrumbs have species lists**: Don't scan folders, read breadcrumb.md
3. **TaxId is unique**: Grep for TaxId when scientific name is ambiguous
4. **Check IsEnriched**: Stubs lack detailed data
