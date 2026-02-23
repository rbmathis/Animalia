namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae;

/// <summary>
/// Interface defining characteristics of Colocongridae (family).
/// </summary>
public interface IColocongridae
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
