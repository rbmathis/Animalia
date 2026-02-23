namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Cruziohyla;

/// <summary>
/// Interface defining characteristics of Cruziohyla (genus).
/// </summary>
public interface ICruziohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
