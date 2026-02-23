namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhabdornithidae;

/// <summary>
/// Interface defining characteristics of Rhabdornithidae (family).
/// </summary>
public interface IRhabdornithidae
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
