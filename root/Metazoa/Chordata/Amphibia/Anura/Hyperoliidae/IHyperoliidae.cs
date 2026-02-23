namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

/// <summary>
/// Interface defining characteristics of Hyperoliidae (family).
/// </summary>
public interface IHyperoliidae
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
