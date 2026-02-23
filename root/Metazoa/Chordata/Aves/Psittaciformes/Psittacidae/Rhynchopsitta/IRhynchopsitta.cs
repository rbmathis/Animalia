namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Rhynchopsitta;

/// <summary>
/// Interface defining characteristics of Rhynchopsitta (genus).
/// </summary>
public interface IRhynchopsitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
