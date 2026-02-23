namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Chimerella;

/// <summary>
/// Interface defining characteristics of Chimerella (genus).
/// </summary>
public interface IChimerella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
