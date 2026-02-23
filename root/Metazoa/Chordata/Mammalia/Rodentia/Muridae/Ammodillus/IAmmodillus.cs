namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ammodillus;

/// <summary>
/// Interface defining characteristics of Ammodillus (genus).
/// </summary>
public interface IAmmodillus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
