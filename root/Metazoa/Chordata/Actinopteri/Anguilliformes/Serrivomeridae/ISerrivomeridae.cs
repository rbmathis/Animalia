namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae;

/// <summary>
/// Interface defining characteristics of Serrivomeridae (family).
/// </summary>
public interface ISerrivomeridae
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
