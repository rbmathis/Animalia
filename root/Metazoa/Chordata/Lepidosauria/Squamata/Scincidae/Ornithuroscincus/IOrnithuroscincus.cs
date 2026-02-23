namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ornithuroscincus;

/// <summary>
/// Interface defining characteristics of Ornithuroscincus (genus).
/// </summary>
public interface IOrnithuroscincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
