namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corcoracidae;

/// <summary>
/// Interface defining characteristics of Corcoracidae (family).
/// </summary>
public interface ICorcoracidae
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
