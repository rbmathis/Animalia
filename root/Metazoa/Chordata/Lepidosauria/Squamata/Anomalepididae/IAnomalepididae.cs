namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomalepididae;

/// <summary>
/// Interface defining characteristics of Anomalepididae (family).
/// </summary>
public interface IAnomalepididae
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
