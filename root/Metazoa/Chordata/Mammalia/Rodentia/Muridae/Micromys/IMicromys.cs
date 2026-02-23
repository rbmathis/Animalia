namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

/// <summary>
/// Interface defining characteristics of Micromys (genus).
/// </summary>
public interface IMicromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
