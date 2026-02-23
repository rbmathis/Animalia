namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Megachasmidae;

/// <summary>
/// Interface defining characteristics of Megachasmidae (family).
/// </summary>
public interface IMegachasmidae
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
