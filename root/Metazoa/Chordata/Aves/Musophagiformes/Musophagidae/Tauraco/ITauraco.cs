namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Tauraco;

/// <summary>
/// Interface defining characteristics of Tauraco (genus).
/// </summary>
public interface ITauraco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
