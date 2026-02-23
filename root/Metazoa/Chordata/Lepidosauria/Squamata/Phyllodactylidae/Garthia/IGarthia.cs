namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Garthia;

/// <summary>
/// Interface defining characteristics of Garthia (genus).
/// </summary>
public interface IGarthia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
