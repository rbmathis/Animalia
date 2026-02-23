namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Dromadidae;

/// <summary>
/// Interface defining characteristics of Dromadidae (family).
/// </summary>
public interface IDromadidae
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
