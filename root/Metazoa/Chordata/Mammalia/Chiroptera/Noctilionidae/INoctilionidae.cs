namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Noctilionidae;

/// <summary>
/// Interface defining characteristics of Noctilionidae (family).
/// </summary>
public interface INoctilionidae
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
