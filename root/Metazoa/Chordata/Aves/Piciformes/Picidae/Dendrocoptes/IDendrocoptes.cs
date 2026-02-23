namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendrocoptes;

/// <summary>
/// Interface defining characteristics of Dendrocoptes (genus).
/// </summary>
public interface IDendrocoptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
