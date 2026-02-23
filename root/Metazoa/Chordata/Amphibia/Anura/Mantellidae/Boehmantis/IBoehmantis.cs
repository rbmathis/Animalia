namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boehmantis;

/// <summary>
/// Interface defining characteristics of Boehmantis (genus).
/// </summary>
public interface IBoehmantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
