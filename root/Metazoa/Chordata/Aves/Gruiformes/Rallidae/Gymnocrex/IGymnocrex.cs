namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gymnocrex;

/// <summary>
/// Interface defining characteristics of Gymnocrex (genus).
/// </summary>
public interface IGymnocrex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
