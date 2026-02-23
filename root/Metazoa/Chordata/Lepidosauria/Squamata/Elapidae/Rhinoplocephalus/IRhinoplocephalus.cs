namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Rhinoplocephalus;

/// <summary>
/// Interface defining characteristics of Rhinoplocephalus (genus).
/// </summary>
public interface IRhinoplocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
