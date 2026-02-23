namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Myrocongridae;

/// <summary>
/// Interface defining characteristics of Myrocongridae (family).
/// </summary>
public interface IMyrocongridae
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
