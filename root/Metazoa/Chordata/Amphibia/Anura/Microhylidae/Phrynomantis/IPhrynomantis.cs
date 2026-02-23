namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Phrynomantis;

/// <summary>
/// Interface defining characteristics of Phrynomantis (genus).
/// </summary>
public interface IPhrynomantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
