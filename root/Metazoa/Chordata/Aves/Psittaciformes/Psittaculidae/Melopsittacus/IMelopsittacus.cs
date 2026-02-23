namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Melopsittacus;

/// <summary>
/// Interface defining characteristics of Melopsittacus (genus).
/// </summary>
public interface IMelopsittacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
