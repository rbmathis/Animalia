namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

/// <summary>
/// Interface defining characteristics of Ophichthidae (family).
/// </summary>
public interface IOphichthidae
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
