namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemiphyllodactylus;

/// <summary>
/// Interface defining characteristics of Hemiphyllodactylus (genus).
/// </summary>
public interface IHemiphyllodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
