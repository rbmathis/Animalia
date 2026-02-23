namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melampittidae;

/// <summary>
/// Interface defining characteristics of Melampittidae (family).
/// </summary>
public interface IMelampittidae
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
