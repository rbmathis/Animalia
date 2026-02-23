namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae;

/// <summary>
/// Interface defining characteristics of Nyctibiidae (family).
/// </summary>
public interface INyctibiidae
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
