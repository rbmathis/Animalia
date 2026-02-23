namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Interface defining characteristics of Rhinopithecus (genus).
/// </summary>
public interface IRhinopithecus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
