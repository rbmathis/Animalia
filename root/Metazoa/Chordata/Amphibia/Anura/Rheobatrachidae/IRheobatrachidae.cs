namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rheobatrachidae;

/// <summary>
/// Interface defining characteristics of Rheobatrachidae (family).
/// </summary>
public interface IRheobatrachidae
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
