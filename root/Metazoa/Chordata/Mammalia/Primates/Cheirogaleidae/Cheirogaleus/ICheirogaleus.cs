namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Cheirogaleus;

/// <summary>
/// Interface defining characteristics of Cheirogaleus (genus).
/// </summary>
public interface ICheirogaleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
