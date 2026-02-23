namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Rhincodontidae;

/// <summary>
/// Interface defining characteristics of Rhincodontidae (family).
/// </summary>
public interface IRhincodontidae
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
