namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Vitreorana;

/// <summary>
/// Interface defining characteristics of Vitreorana (genus).
/// </summary>
public interface IVitreorana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
