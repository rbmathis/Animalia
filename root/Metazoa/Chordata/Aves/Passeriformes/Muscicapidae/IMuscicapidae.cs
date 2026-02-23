namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

/// <summary>
/// Interface defining characteristics of Muscicapidae (family).
/// </summary>
public interface IMuscicapidae
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
