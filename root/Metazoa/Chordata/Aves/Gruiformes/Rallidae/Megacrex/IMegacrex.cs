namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Megacrex;

/// <summary>
/// Interface defining characteristics of Megacrex (genus).
/// </summary>
public interface IMegacrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
