namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

/// <summary>
/// Interface defining characteristics of Psittacidae (family).
/// </summary>
public interface IPsittacidae
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
