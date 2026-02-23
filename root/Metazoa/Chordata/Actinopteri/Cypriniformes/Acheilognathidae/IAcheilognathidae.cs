namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

/// <summary>
/// Interface defining characteristics of Acheilognathidae (family).
/// </summary>
public interface IAcheilognathidae
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
