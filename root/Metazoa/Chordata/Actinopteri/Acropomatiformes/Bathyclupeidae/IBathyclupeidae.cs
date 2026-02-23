namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae;

/// <summary>
/// Interface defining characteristics of Bathyclupeidae (family).
/// </summary>
public interface IBathyclupeidae
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
