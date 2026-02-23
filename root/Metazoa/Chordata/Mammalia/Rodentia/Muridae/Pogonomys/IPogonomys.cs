namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys;

/// <summary>
/// Interface defining characteristics of Pogonomys (genus).
/// </summary>
public interface IPogonomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
