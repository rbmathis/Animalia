namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae;

/// <summary>
/// Interface defining characteristics of Struthionidae (family).
/// </summary>
public interface IStruthionidae
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
