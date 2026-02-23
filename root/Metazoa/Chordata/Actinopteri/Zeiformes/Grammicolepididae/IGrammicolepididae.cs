namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae;

/// <summary>
/// Interface defining characteristics of Grammicolepididae (family).
/// </summary>
public interface IGrammicolepididae
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
