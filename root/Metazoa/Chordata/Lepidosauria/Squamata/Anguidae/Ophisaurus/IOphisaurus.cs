namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Ophisaurus;

/// <summary>
/// Interface defining characteristics of Ophisaurus (genus).
/// </summary>
public interface IOphisaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
