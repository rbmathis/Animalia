namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryaderces;

/// <summary>
/// Interface defining characteristics of Dryaderces (genus).
/// </summary>
public interface IDryaderces
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
