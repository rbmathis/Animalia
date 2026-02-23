namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Nymphargus;

/// <summary>
/// Interface defining characteristics of Nymphargus (genus).
/// </summary>
public interface INymphargus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
