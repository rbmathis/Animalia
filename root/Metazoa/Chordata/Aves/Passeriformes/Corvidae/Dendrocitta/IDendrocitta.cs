namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Dendrocitta;

/// <summary>
/// Interface defining characteristics of Dendrocitta (genus).
/// </summary>
public interface IDendrocitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
