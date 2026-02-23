namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae;

/// <summary>
/// Interface defining characteristics of Siphonopidae (family).
/// </summary>
public interface ISiphonopidae
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
