namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hoplophryne;

/// <summary>
/// Interface defining characteristics of Hoplophryne (genus).
/// </summary>
public interface IHoplophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
