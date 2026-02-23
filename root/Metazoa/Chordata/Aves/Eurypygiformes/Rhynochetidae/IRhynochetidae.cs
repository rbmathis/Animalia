namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Eurypygiformes.Rhynochetidae;

/// <summary>
/// Interface defining characteristics of Rhynochetidae (family).
/// </summary>
public interface IRhynochetidae
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
