namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Dendrocolaptes;

/// <summary>
/// Interface defining characteristics of Dendrocolaptes (genus).
/// </summary>
public interface IDendrocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
