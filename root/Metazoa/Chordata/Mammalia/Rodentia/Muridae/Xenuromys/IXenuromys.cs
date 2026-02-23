namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Xenuromys;

/// <summary>
/// Interface defining characteristics of Xenuromys (genus).
/// </summary>
public interface IXenuromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
