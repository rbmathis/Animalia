namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Mentocrex;

/// <summary>
/// Interface defining characteristics of Mentocrex (genus).
/// </summary>
public interface IMentocrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
