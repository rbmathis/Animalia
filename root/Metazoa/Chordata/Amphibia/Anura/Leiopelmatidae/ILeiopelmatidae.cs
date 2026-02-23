namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leiopelmatidae;

/// <summary>
/// Interface defining characteristics of Leiopelmatidae (family).
/// </summary>
public interface ILeiopelmatidae
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
