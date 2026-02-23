namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae;

/// <summary>
/// Interface defining characteristics of Aphyonidae (family).
/// </summary>
public interface IAphyonidae
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
