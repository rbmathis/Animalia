namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae.Ctenodactylus;

/// <summary>
/// Interface defining characteristics of Ctenodactylus (genus).
/// </summary>
public interface ICtenodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
