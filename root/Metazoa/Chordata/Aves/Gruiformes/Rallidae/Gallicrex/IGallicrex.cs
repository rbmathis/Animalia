namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallicrex;

/// <summary>
/// Interface defining characteristics of Gallicrex (genus).
/// </summary>
public interface IGallicrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
