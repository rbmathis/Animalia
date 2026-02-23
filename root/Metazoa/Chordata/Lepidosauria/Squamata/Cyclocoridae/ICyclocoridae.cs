namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae;

/// <summary>
/// Interface defining characteristics of Cyclocoridae (family).
/// </summary>
public interface ICyclocoridae
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
