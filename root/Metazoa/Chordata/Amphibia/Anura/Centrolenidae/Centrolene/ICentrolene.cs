namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolene;

/// <summary>
/// Interface defining characteristics of Centrolene (genus).
/// </summary>
public interface ICentrolene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
