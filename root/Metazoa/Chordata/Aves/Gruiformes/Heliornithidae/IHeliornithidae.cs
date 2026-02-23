namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae;

/// <summary>
/// Interface defining characteristics of Heliornithidae (family).
/// </summary>
public interface IHeliornithidae
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
