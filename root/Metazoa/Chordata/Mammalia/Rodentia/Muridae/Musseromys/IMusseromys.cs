namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Musseromys;

/// <summary>
/// Interface defining characteristics of Musseromys (genus).
/// </summary>
public interface IMusseromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
