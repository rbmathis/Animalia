namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Gerrhosaurus;

/// <summary>
/// Interface defining characteristics of Gerrhosaurus (genus).
/// </summary>
public interface IGerrhosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
