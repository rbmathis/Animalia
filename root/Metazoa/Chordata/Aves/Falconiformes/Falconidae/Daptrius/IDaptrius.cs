namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Daptrius;

/// <summary>
/// Interface defining characteristics of Daptrius (genus).
/// </summary>
public interface IDaptrius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
