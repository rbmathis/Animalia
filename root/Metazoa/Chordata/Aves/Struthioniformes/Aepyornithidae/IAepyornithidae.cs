namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae;

/// <summary>
/// Interface defining characteristics of Aepyornithidae (family).
/// </summary>
public interface IAepyornithidae
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
