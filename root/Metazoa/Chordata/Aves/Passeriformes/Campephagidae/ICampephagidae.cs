namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

/// <summary>
/// Interface defining characteristics of Campephagidae (family).
/// </summary>
public interface ICampephagidae
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
