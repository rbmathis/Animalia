namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Oxyconger;

/// <summary>
/// Interface defining characteristics of Oxyconger (genus).
/// </summary>
public interface IOxyconger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
