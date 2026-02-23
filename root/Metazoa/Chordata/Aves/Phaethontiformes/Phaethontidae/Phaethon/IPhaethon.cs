namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phaethontiformes.Phaethontidae.Phaethon;

/// <summary>
/// Interface defining characteristics of Phaethon (genus).
/// </summary>
public interface IPhaethon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
