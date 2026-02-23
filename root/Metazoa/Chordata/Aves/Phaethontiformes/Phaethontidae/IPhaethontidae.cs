namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phaethontiformes.Phaethontidae;

/// <summary>
/// Interface defining characteristics of Phaethontidae (family).
/// </summary>
public interface IPhaethontidae
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
