namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leptosiaphos;

/// <summary>
/// Interface defining characteristics of Leptosiaphos (genus).
/// </summary>
public interface ILeptosiaphos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
