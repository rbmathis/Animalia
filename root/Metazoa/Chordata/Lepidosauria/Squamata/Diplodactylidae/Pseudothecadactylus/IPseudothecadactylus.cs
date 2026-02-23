namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Pseudothecadactylus;

/// <summary>
/// Interface defining characteristics of Pseudothecadactylus (genus).
/// </summary>
public interface IPseudothecadactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
