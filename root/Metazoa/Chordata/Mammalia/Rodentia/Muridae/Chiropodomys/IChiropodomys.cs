namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiropodomys;

/// <summary>
/// Interface defining characteristics of Chiropodomys (genus).
/// </summary>
public interface IChiropodomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
