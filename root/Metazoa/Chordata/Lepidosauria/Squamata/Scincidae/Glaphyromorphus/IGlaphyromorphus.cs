namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Glaphyromorphus;

/// <summary>
/// Interface defining characteristics of Glaphyromorphus (genus).
/// </summary>
public interface IGlaphyromorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
