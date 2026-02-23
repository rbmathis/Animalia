namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Pontoporiidae;

/// <summary>
/// Interface defining characteristics of Pontoporiidae (family).
/// </summary>
public interface IPontoporiidae
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
