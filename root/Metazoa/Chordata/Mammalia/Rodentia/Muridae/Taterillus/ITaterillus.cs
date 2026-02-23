namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taterillus;

/// <summary>
/// Interface defining characteristics of Taterillus (genus).
/// </summary>
public interface ITaterillus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
