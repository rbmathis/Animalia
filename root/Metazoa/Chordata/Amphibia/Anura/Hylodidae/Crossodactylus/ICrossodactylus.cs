namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Crossodactylus;

/// <summary>
/// Interface defining characteristics of Crossodactylus (genus).
/// </summary>
public interface ICrossodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
