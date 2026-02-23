namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Monognathidae;

/// <summary>
/// Interface defining characteristics of Monognathidae (family).
/// </summary>
public interface IMonognathidae
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
