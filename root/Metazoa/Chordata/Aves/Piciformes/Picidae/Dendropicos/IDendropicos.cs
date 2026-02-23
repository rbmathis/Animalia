namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendropicos;

/// <summary>
/// Interface defining characteristics of Dendropicos (genus).
/// </summary>
public interface IDendropicos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
