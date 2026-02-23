namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae.Galeopterus;

/// <summary>
/// Interface defining characteristics of Galeopterus (genus).
/// </summary>
public interface IGaleopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
