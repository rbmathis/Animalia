namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae;

/// <summary>
/// Interface defining characteristics of Rhinonycteridae (family).
/// </summary>
public interface IRhinonycteridae
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
