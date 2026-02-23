namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Nilopegamys;

/// <summary>
/// Interface defining characteristics of Nilopegamys (genus).
/// </summary>
public interface INilopegamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
