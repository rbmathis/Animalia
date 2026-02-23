namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cryptoblepharus;

/// <summary>
/// Interface defining characteristics of Cryptoblepharus (genus).
/// </summary>
public interface ICryptoblepharus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
