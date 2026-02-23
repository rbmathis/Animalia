namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae;

/// <summary>
/// Interface defining characteristics of Brachycephalidae (family).
/// </summary>
public interface IBrachycephalidae
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
