namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leporillus;

/// <summary>
/// Interface defining characteristics of Leporillus (genus).
/// </summary>
public interface ILeporillus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
