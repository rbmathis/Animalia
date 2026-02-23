namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhinocheilus;

/// <summary>
/// Interface defining characteristics of Rhinocheilus (genus).
/// </summary>
public interface IRhinocheilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
