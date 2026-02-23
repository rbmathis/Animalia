namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae;

/// <summary>
/// Interface defining characteristics of Prionopidae (family).
/// </summary>
public interface IPrionopidae
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
