namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pseudobias;

/// <summary>
/// Interface defining characteristics of Pseudobias (genus).
/// </summary>
public interface IPseudobias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
