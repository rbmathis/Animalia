namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae;

/// <summary>
/// Interface defining characteristics of Megapodiidae (family).
/// </summary>
public interface IMegapodiidae
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
