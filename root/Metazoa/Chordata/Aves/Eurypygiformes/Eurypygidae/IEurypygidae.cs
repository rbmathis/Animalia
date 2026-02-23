namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Eurypygiformes.Eurypygidae;

/// <summary>
/// Interface defining characteristics of Eurypygidae (family).
/// </summary>
public interface IEurypygidae
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
