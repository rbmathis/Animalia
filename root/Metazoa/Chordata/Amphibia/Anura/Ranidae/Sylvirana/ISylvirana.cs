namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sylvirana;

/// <summary>
/// Interface defining characteristics of Sylvirana (genus).
/// </summary>
public interface ISylvirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
