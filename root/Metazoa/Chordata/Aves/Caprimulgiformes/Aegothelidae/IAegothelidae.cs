namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Aegothelidae;

/// <summary>
/// Interface defining characteristics of Aegothelidae (family).
/// </summary>
public interface IAegothelidae
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
