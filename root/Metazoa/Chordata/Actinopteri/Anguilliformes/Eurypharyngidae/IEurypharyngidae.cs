namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae;

/// <summary>
/// Interface defining characteristics of Eurypharyngidae (family).
/// </summary>
public interface IEurypharyngidae
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
