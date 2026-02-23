namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Rhyacotritonidae;

/// <summary>
/// Interface defining characteristics of Rhyacotritonidae (family).
/// </summary>
public interface IRhyacotritonidae
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
