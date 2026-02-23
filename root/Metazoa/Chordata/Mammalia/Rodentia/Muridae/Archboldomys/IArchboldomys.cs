namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Archboldomys;

/// <summary>
/// Interface defining characteristics of Archboldomys (genus).
/// </summary>
public interface IArchboldomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
