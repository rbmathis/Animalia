namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae;

/// <summary>
/// Interface defining characteristics of Moringuidae (family).
/// </summary>
public interface IMoringuidae
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
