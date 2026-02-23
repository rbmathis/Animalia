namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Papurana;

/// <summary>
/// Interface defining characteristics of Papurana (genus).
/// </summary>
public interface IPapurana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
