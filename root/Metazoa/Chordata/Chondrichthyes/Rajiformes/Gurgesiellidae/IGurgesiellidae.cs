namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Gurgesiellidae;

/// <summary>
/// Interface defining characteristics of Gurgesiellidae (family).
/// </summary>
public interface IGurgesiellidae
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
