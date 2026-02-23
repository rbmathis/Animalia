namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae;

/// <summary>
/// Interface defining characteristics of Gigantactinidae (family).
/// </summary>
public interface IGigantactinidae
{
    /// <inheritdoc />
    string FamilyName { get; }

    /// <inheritdoc />
    string[] FamilyCharacteristics { get; }

    /// <inheritdoc />
    bool HasNonRetractableClaws { get; }

    /// <inheritdoc />
    bool IsDigitigrade { get; }

    /// <inheritdoc />
    int FrontToeCount { get; }

    /// <inheritdoc />
    int HindToeCount { get; }

    /// <inheritdoc />
    string[] CommunicationMethods { get; }

}
