namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae;

/// <summary>
/// Interface defining characteristics of Dasypodidae (family).
/// </summary>
public interface IDasypodidae
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
