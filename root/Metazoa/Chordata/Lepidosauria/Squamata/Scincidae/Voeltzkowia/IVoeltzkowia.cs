namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Voeltzkowia;

/// <summary>
/// Interface defining characteristics of Voeltzkowia (genus).
/// </summary>
public interface IVoeltzkowia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
