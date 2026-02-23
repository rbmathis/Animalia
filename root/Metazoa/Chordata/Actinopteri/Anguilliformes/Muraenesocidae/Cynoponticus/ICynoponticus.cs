namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Cynoponticus;

/// <summary>
/// Interface defining characteristics of Cynoponticus (genus).
/// </summary>
public interface ICynoponticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
