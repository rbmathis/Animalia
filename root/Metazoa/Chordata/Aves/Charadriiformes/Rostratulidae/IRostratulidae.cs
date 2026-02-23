namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae;

/// <summary>
/// Interface defining characteristics of Rostratulidae (family).
/// </summary>
public interface IRostratulidae
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
