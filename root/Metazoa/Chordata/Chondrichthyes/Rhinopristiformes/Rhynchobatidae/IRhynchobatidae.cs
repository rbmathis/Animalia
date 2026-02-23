namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae;

/// <summary>
/// Interface defining characteristics of Rhynchobatidae (family).
/// </summary>
public interface IRhynchobatidae
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
