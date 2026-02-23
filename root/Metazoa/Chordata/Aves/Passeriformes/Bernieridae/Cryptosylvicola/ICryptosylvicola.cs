namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Cryptosylvicola;

/// <summary>
/// Interface defining characteristics of Cryptosylvicola (genus).
/// </summary>
public interface ICryptosylvicola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
