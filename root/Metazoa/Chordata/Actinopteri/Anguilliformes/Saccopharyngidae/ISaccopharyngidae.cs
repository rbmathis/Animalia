namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae;

/// <summary>
/// Interface defining characteristics of Saccopharyngidae (family).
/// </summary>
public interface ISaccopharyngidae
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
