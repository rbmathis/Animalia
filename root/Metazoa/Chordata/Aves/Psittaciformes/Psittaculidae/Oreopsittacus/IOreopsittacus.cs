namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Oreopsittacus;

/// <summary>
/// Interface defining characteristics of Oreopsittacus (genus).
/// </summary>
public interface IOreopsittacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
