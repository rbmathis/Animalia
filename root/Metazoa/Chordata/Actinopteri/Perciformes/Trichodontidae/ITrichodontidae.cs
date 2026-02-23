namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae;

/// <summary>
/// Interface defining characteristics of Trichodontidae (family).
/// </summary>
public interface ITrichodontidae
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
