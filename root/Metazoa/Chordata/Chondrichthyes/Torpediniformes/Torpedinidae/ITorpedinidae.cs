namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae;

/// <summary>
/// Interface defining characteristics of Torpedinidae (family).
/// </summary>
public interface ITorpedinidae
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
