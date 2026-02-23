namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

/// <summary>
/// Interface defining characteristics of Meliphagidae (family).
/// </summary>
public interface IMeliphagidae
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
