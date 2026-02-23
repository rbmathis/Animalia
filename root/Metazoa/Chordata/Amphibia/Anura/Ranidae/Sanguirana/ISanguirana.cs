namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sanguirana;

/// <summary>
/// Interface defining characteristics of Sanguirana (genus).
/// </summary>
public interface ISanguirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
