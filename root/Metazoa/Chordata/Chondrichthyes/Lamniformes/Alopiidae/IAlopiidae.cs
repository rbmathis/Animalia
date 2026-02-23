namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Alopiidae;

/// <summary>
/// Interface defining characteristics of Alopiidae (family).
/// </summary>
public interface IAlopiidae
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
