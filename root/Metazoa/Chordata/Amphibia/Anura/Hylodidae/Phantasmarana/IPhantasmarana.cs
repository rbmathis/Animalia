namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Phantasmarana;

/// <summary>
/// Interface defining characteristics of Phantasmarana (genus).
/// </summary>
public interface IPhantasmarana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
