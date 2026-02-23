namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

/// <summary>
/// Interface defining characteristics of Musophagidae (family).
/// </summary>
public interface IMusophagidae
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
