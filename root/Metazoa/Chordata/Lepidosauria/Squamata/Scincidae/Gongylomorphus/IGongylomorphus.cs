namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Gongylomorphus;

/// <summary>
/// Interface defining characteristics of Gongylomorphus (genus).
/// </summary>
public interface IGongylomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
