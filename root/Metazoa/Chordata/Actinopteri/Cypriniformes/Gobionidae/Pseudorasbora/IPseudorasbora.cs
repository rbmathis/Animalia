namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pseudorasbora;

/// <summary>
/// Interface defining characteristics of Pseudorasbora (genus).
/// </summary>
public interface IPseudorasbora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
