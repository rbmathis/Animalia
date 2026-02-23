namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae;

/// <summary>
/// Interface defining characteristics of Acrochordidae (family).
/// </summary>
public interface IAcrochordidae
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
