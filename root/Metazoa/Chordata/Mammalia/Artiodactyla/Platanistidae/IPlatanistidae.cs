namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Platanistidae;

/// <summary>
/// Interface defining characteristics of Platanistidae (family).
/// </summary>
public interface IPlatanistidae
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
