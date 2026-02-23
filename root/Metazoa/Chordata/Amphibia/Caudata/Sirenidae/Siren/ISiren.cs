namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Sirenidae.Siren;

/// <summary>
/// Interface defining characteristics of Siren (genus).
/// </summary>
public interface ISiren
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
