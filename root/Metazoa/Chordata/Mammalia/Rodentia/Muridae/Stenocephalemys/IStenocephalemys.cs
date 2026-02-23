namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stenocephalemys;

/// <summary>
/// Interface defining characteristics of Stenocephalemys (genus).
/// </summary>
public interface IStenocephalemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
