namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae;

/// <summary>
/// Interface defining characteristics of Rhinochimaeridae (family).
/// </summary>
public interface IRhinochimaeridae
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
