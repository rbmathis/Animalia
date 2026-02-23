namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Coeranoscincus;

/// <summary>
/// Interface defining characteristics of Coeranoscincus (genus).
/// </summary>
public interface ICoeranoscincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
