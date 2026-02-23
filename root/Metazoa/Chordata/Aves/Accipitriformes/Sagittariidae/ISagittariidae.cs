namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Sagittariidae;

/// <summary>
/// Interface defining characteristics of Sagittariidae (family).
/// </summary>
public interface ISagittariidae
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
