namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

/// <summary>
/// Interface defining characteristics of Gerrhosauridae (family).
/// </summary>
public interface IGerrhosauridae
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
