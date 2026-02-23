namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amnirana;

/// <summary>
/// Interface defining characteristics of Amnirana (genus).
/// </summary>
public interface IAmnirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
