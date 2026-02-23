namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Nidirana;

/// <summary>
/// Interface defining characteristics of Nidirana (genus).
/// </summary>
public interface INidirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
