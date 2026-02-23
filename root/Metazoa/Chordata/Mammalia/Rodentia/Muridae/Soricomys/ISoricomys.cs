namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Soricomys;

/// <summary>
/// Interface defining characteristics of Soricomys (genus).
/// </summary>
public interface ISoricomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
