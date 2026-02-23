namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Carchariidae;

/// <summary>
/// Interface defining characteristics of Carchariidae (family).
/// </summary>
public interface ICarchariidae
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
