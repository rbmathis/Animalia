namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Cophosaurus;

/// <summary>
/// Interface defining characteristics of Cophosaurus (genus).
/// </summary>
public interface ICophosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
