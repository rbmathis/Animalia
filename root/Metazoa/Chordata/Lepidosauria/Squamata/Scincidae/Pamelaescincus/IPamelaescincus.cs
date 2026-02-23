namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pamelaescincus;

/// <summary>
/// Interface defining characteristics of Pamelaescincus (genus).
/// </summary>
public interface IPamelaescincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
