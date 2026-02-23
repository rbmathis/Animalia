namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tropidoscincus;

/// <summary>
/// Interface defining characteristics of Tropidoscincus (genus).
/// </summary>
public interface ITropidoscincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
