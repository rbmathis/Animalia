namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

/// <summary>
/// Interface defining characteristics of Phalangeridae (family).
/// </summary>
public interface IPhalangeridae
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
