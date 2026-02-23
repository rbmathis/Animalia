namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

/// <summary>
/// Interface defining characteristics of Lophiidae (family).
/// </summary>
public interface ILophiidae
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
