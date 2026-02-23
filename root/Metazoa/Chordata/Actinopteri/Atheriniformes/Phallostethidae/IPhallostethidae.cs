namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae;

/// <summary>
/// Interface defining characteristics of Phallostethidae (family).
/// </summary>
public interface IPhallostethidae
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
