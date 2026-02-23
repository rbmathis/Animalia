namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae;

/// <summary>
/// Interface defining characteristics of Aegithalidae (family).
/// </summary>
public interface IAegithalidae
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
