namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyanoramphus;

/// <summary>
/// Interface defining characteristics of Cyanoramphus (genus).
/// </summary>
public interface ICyanoramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
