namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Sachatamia;

/// <summary>
/// Interface defining characteristics of Sachatamia (genus).
/// </summary>
public interface ISachatamia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
