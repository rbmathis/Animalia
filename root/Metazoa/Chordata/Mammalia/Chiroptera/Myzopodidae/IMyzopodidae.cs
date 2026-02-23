namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Myzopodidae;

/// <summary>
/// Interface defining characteristics of Myzopodidae (family).
/// </summary>
public interface IMyzopodidae
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
