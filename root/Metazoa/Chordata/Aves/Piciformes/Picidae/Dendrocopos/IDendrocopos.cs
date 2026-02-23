namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendrocopos;

/// <summary>
/// Interface defining characteristics of Dendrocopos (genus).
/// </summary>
public interface IDendrocopos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
