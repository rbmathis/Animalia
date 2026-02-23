namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae;

/// <summary>
/// Interface defining characteristics of Diplomystidae (family).
/// </summary>
public interface IDiplomystidae
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
