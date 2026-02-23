namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae;

/// <summary>
/// Interface defining characteristics of Crotophagidae (family).
/// </summary>
public interface ICrotophagidae
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
