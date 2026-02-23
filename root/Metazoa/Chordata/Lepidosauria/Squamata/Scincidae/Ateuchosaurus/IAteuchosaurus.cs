namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ateuchosaurus;

/// <summary>
/// Interface defining characteristics of Ateuchosaurus (genus).
/// </summary>
public interface IAteuchosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
