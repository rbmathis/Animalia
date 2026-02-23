namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Neobalaenidae;

/// <summary>
/// Interface defining characteristics of Neobalaenidae (family).
/// </summary>
public interface INeobalaenidae
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
