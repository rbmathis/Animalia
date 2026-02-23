namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae;

/// <summary>
/// Interface defining characteristics of Draconettidae (family).
/// </summary>
public interface IDraconettidae
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
