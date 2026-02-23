namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Tarsipedidae;

/// <summary>
/// Interface defining characteristics of Tarsipedidae (family).
/// </summary>
public interface ITarsipedidae
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
