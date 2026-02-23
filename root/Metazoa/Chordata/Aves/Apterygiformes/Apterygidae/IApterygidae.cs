namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apterygiformes.Apterygidae;

/// <summary>
/// Interface defining characteristics of Apterygidae (family).
/// </summary>
public interface IApterygidae
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
