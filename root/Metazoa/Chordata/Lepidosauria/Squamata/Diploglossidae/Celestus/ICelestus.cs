namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Celestus;

/// <summary>
/// Interface defining characteristics of Celestus (genus).
/// </summary>
public interface ICelestus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
