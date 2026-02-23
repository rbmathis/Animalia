namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triodontidae;

/// <summary>
/// Interface defining characteristics of Triodontidae (family).
/// </summary>
public interface ITriodontidae
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
