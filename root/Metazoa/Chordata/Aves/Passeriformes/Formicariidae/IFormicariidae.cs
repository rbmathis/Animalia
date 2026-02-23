namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

/// <summary>
/// Interface defining characteristics of Formicariidae (family).
/// </summary>
public interface IFormicariidae
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
