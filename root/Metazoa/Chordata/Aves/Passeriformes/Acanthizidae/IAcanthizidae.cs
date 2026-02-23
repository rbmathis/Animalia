namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

/// <summary>
/// Interface defining characteristics of Acanthizidae (family).
/// </summary>
public interface IAcanthizidae
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
