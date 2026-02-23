namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pseudoacontias;

/// <summary>
/// Interface defining characteristics of Pseudoacontias (genus).
/// </summary>
public interface IPseudoacontias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
