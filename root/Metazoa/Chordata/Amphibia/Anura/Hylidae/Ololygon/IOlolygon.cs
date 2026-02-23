namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ololygon;

/// <summary>
/// Interface defining characteristics of Ololygon (genus).
/// </summary>
public interface IOlolygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
