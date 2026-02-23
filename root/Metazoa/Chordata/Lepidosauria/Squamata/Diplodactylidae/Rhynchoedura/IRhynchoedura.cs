namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Rhynchoedura;

/// <summary>
/// Interface defining characteristics of Rhynchoedura (genus).
/// </summary>
public interface IRhynchoedura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
