namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Batrachostomatidae;

/// <summary>
/// Interface defining characteristics of Batrachostomatidae (family).
/// </summary>
public interface IBatrachostomatidae
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
