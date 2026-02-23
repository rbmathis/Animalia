namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae;

/// <summary>
/// Interface defining characteristics of Rhinodermatidae (family).
/// </summary>
public interface IRhinodermatidae
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
