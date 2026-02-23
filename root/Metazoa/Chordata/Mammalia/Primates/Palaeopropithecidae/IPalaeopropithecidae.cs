namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae;

/// <summary>
/// Interface defining characteristics of Palaeopropithecidae (family).
/// </summary>
public interface IPalaeopropithecidae
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
