namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Banjosidae;

/// <summary>
/// Interface defining characteristics of Banjosidae (family).
/// </summary>
public interface IBanjosidae
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
