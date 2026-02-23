namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae;

/// <summary>
/// Interface defining characteristics of Cyematidae (family).
/// </summary>
public interface ICyematidae
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
