namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

/// <summary>
/// Interface defining characteristics of Dicroglossidae (family).
/// </summary>
public interface IDicroglossidae
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
