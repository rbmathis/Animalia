namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Melloria;

/// <summary>
/// Interface defining characteristics of Melloria (genus).
/// </summary>
public interface IMelloria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
