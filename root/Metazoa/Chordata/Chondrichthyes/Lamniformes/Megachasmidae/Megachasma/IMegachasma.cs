namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Megachasmidae.Megachasma;

/// <summary>
/// Interface defining characteristics of Megachasma (genus).
/// </summary>
public interface IMegachasma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
