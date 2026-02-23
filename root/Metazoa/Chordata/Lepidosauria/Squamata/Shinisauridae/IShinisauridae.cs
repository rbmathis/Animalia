namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Shinisauridae;

/// <summary>
/// Interface defining characteristics of Shinisauridae (family).
/// </summary>
public interface IShinisauridae
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
