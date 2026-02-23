namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Dicamptodontidae;

/// <summary>
/// Interface defining characteristics of Dicamptodontidae (family).
/// </summary>
public interface IDicamptodontidae
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
