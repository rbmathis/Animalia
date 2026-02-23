namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae;

/// <summary>
/// Interface defining characteristics of Acanthisittidae (family).
/// </summary>
public interface IAcanthisittidae
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
