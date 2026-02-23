namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae;

/// <summary>
/// Interface defining characteristics of Narkidae (family).
/// </summary>
public interface INarkidae
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
