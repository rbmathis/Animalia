namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Synapturanus;

/// <summary>
/// Interface defining characteristics of Synapturanus (genus).
/// </summary>
public interface ISynapturanus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
