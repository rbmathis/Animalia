namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae.Cynocephalus;

/// <summary>
/// Interface defining characteristics of Cynocephalus (genus).
/// </summary>
public interface ICynocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
