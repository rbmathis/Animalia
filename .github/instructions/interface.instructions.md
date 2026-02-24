---
applyTo: "**/I[A-Z]*.cs"
---

# Interface File Instructions

This file matches **interface files** (files starting with `I` followed by uppercase, e.g., `ICanis.cs`).

## Purpose

Interfaces define contracts that genus/family classes must implement. They establish behavioral capabilities at each taxonomic level.

## File Structure

- **Naming**: `I{TaxonName}.cs` (e.g., `ICanis.cs`, `ICanidae.cs`)
- **Location**: Same folder as the corresponding class
- **Namespace**: Same as sibling classes

## Common Interface Patterns

### Genus Interface (e.g., `ICanis`)
```csharp
public interface ICanis
{
    string GenusName { get; }
    string[] GenusCharacteristics { get; }
    bool CanInterbreed { get; }
}
```

### Family Interface (e.g., `ICanidae`)
```csharp
public interface ICanidae
{
    string FamilyName { get; }
    string[] FamilyCharacteristics { get; }
}
```

### Behavioral Interfaces
- `IPackAnimal` - Social hunting behavior
- `IThermoregulation` - Temperature regulation
- `INotochord` - Chordate characteristic

## Finding Implementations

To find all classes implementing an interface:

```bash
# Find all IPackAnimal implementations
grep -r "IPackAnimal" root/**/*.cs

# Find all species in a genus (implement ICanis via Canis base class)
ls root/**/Canis/Canis_*.cs
```

## Renaming Impact

When renaming an interface (e.g., `IPackAnimal` → `ISocialHunter`):

1. **Interface file**: Rename and update interface name
2. **Implementing classes**: Update all `: IPackAnimal` declarations
3. **Using statements**: Update any explicit interface references
4. **Breadcrumbs**: Update any interface tags

## Navigation Rules

- **Implementing class**: Same folder, without `I` prefix (e.g., `ICanis.cs` → `Canis.cs`)
- **Species implementations**: Same folder, `Genus_*.cs` files inherit via genus class
- **Parent interface**: One folder up, `I{ParentTaxon}.cs`
