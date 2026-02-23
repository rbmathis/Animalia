namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anniellidae;

/// <summary>
/// Interface defining characteristics of Anniellidae (family).
/// </summary>
public interface IAnniellidae
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
