namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Cetorhinidae;

/// <summary>
/// Interface defining characteristics of Cetorhinidae (family).
/// </summary>
public interface ICetorhinidae
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
