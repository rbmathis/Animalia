namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Baiyankamys;

/// <summary>
/// Interface defining characteristics of Baiyankamys (genus).
/// </summary>
public interface IBaiyankamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
