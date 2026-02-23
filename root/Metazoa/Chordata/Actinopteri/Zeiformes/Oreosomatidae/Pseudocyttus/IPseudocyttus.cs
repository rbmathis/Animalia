namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Pseudocyttus;

/// <summary>
/// Interface defining characteristics of Pseudocyttus (genus).
/// </summary>
public interface IPseudocyttus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
