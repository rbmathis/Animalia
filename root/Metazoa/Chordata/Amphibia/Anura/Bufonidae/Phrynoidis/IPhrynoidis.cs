namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Phrynoidis;

/// <summary>
/// Interface defining characteristics of Phrynoidis (genus).
/// </summary>
public interface IPhrynoidis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
