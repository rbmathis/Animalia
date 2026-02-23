namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Neocyema;

/// <summary>
/// Interface defining characteristics of Neocyema (genus).
/// </summary>
public interface INeocyema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
