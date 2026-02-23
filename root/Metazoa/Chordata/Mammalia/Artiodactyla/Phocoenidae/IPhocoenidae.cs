namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae;

/// <summary>
/// Interface defining characteristics of Phocoenidae (family).
/// </summary>
public interface IPhocoenidae
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
