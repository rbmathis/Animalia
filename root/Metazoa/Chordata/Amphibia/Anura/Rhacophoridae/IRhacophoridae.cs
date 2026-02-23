namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

/// <summary>
/// Interface defining characteristics of Rhacophoridae (family).
/// </summary>
public interface IRhacophoridae
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
