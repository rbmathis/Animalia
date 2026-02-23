namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Conopophagidae;

/// <summary>
/// Interface defining characteristics of Conopophagidae (family).
/// </summary>
public interface IConopophagidae
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
