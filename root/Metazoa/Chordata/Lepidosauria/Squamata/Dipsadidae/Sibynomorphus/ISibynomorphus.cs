namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Sibynomorphus;

/// <summary>
/// Interface defining characteristics of Sibynomorphus (genus).
/// </summary>
public interface ISibynomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
