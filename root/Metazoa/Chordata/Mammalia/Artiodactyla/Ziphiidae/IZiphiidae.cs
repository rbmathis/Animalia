namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

/// <summary>
/// Interface defining characteristics of Ziphiidae (family).
/// </summary>
public interface IZiphiidae
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
