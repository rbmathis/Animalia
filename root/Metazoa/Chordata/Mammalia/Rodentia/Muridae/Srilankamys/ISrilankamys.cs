namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Srilankamys;

/// <summary>
/// Interface defining characteristics of Srilankamys (genus).
/// </summary>
public interface ISrilankamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
