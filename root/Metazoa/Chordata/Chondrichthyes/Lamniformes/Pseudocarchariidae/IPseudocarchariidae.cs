namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Pseudocarchariidae;

/// <summary>
/// Interface defining characteristics of Pseudocarchariidae (family).
/// </summary>
public interface IPseudocarchariidae
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
