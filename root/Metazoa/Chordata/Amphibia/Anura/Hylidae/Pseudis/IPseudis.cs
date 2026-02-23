namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudis;

/// <summary>
/// Interface defining characteristics of Pseudis (genus).
/// </summary>
public interface IPseudis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
