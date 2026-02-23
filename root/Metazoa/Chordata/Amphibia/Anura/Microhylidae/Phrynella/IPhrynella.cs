namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Phrynella;

/// <summary>
/// Interface defining characteristics of Phrynella (genus).
/// </summary>
public interface IPhrynella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
