namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Odontaspididae;

/// <summary>
/// Interface defining characteristics of Odontaspididae (family).
/// </summary>
public interface IOdontaspididae
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
