namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae;

/// <summary>
/// Interface defining characteristics of Sundadanionidae (family).
/// </summary>
public interface ISundadanionidae
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
