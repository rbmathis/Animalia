namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae;

/// <summary>
/// Interface defining characteristics of Cheirogaleidae (family).
/// </summary>
public interface ICheirogaleidae
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
