namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Haemodracon;

/// <summary>
/// Interface defining characteristics of Haemodracon (genus).
/// </summary>
public interface IHaemodracon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
