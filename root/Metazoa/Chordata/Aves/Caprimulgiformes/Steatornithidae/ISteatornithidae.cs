namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Steatornithidae;

/// <summary>
/// Interface defining characteristics of Steatornithidae (family).
/// </summary>
public interface ISteatornithidae
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
