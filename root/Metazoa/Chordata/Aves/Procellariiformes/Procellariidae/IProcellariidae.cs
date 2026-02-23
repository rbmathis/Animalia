namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

/// <summary>
/// Interface defining characteristics of Procellariidae (family).
/// </summary>
public interface IProcellariidae
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
