namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhopilidae;

/// <summary>
/// Interface defining characteristics of Gerrhopilidae (family).
/// </summary>
public interface IGerrhopilidae
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
