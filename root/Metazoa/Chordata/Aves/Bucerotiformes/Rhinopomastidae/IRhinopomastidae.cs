namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Rhinopomastidae;

/// <summary>
/// Interface defining characteristics of Rhinopomastidae (family).
/// </summary>
public interface IRhinopomastidae
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
