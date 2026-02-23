namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Eschrichtiidae;

/// <summary>
/// Interface defining characteristics of Eschrichtiidae (family).
/// </summary>
public interface IEschrichtiidae
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
