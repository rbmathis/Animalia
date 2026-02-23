namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae;

/// <summary>
/// Interface defining characteristics of Dromaiidae (family).
/// </summary>
public interface IDromaiidae
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
