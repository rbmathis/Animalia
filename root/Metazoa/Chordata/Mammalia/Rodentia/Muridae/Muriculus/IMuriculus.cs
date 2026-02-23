namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muriculus;

/// <summary>
/// Interface defining characteristics of Muriculus (genus).
/// </summary>
public interface IMuriculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
