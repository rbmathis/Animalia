namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Peltops;

/// <summary>
/// Interface defining characteristics of Peltops (genus).
/// </summary>
public interface IPeltops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
