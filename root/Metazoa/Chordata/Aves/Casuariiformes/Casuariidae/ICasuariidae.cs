namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae;

/// <summary>
/// Interface defining characteristics of Casuariidae (family).
/// </summary>
public interface ICasuariidae
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
