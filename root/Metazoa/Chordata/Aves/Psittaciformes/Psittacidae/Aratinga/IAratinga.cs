namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Aratinga;

/// <summary>
/// Interface defining characteristics of Aratinga (genus).
/// </summary>
public interface IAratinga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
