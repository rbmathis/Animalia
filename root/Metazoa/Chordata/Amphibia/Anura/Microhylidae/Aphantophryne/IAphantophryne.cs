namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Aphantophryne;

/// <summary>
/// Interface defining characteristics of Aphantophryne (genus).
/// </summary>
public interface IAphantophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
