namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pseudoceramodactylus;

/// <summary>
/// Interface defining characteristics of Pseudoceramodactylus (genus).
/// </summary>
public interface IPseudoceramodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
