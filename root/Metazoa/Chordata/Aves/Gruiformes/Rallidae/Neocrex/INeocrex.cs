namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Neocrex;

/// <summary>
/// Interface defining characteristics of Neocrex (genus).
/// </summary>
public interface INeocrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
