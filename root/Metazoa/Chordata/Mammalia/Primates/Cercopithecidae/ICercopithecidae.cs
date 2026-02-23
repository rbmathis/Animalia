namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

/// <summary>
/// Interface defining characteristics of Cercopithecidae (family).
/// </summary>
public interface ICercopithecidae
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
