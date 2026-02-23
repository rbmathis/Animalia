namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cyclodomorphus;

/// <summary>
/// Interface defining characteristics of Cyclodomorphus (genus).
/// </summary>
public interface ICyclodomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
