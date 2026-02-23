namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Bolbopsittacus;

/// <summary>
/// Interface defining characteristics of Bolbopsittacus (genus).
/// </summary>
public interface IBolbopsittacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
