namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae;

/// <summary>
/// Interface defining characteristics of Cycloramphidae (family).
/// </summary>
public interface ICycloramphidae
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
