namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Aulorhynchidae;

/// <summary>
/// Interface defining characteristics of Aulorhynchidae (family).
/// </summary>
public interface IAulorhynchidae
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
