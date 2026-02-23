namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Dactylocnemis;

/// <summary>
/// Interface defining characteristics of Dactylocnemis (genus).
/// </summary>
public interface IDactylocnemis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
