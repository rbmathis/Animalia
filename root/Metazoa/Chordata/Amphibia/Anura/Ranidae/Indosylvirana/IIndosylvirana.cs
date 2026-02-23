namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Indosylvirana;

/// <summary>
/// Interface defining characteristics of Indosylvirana (genus).
/// </summary>
public interface IIndosylvirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
