namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Protanguillidae;

/// <summary>
/// Interface defining characteristics of Protanguillidae (family).
/// </summary>
public interface IProtanguillidae
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
