namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Stegostomatidae.Stegostoma;

/// <summary>
/// Interface defining characteristics of Stegostoma (genus).
/// </summary>
public interface IStegostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
