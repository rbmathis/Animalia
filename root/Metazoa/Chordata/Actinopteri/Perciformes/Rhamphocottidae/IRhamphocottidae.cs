namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Rhamphocottidae;

/// <summary>
/// Interface defining characteristics of Rhamphocottidae (family).
/// </summary>
public interface IRhamphocottidae
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
