namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Eurostopodidae;

/// <summary>
/// Interface defining characteristics of Eurostopodidae (family).
/// </summary>
public interface IEurostopodidae
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
