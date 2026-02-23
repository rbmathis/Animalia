namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae.Oreocharis;

/// <summary>
/// Interface defining characteristics of Oreocharis (genus).
/// </summary>
public interface IOreocharis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
