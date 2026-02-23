namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Antilocapridae;

/// <summary>
/// Interface defining characteristics of Antilocapridae (family).
/// </summary>
public interface IAntilocapridae
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
