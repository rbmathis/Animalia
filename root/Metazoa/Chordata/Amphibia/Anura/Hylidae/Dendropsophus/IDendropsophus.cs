namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dendropsophus;

/// <summary>
/// Interface defining characteristics of Dendropsophus (genus).
/// </summary>
public interface IDendropsophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
