namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Dendrexetastes;

/// <summary>
/// Interface defining characteristics of Dendrexetastes (genus).
/// </summary>
public interface IDendrexetastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
