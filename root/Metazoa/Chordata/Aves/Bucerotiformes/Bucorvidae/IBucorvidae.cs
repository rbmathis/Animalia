namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucorvidae;

/// <summary>
/// Interface defining characteristics of Bucorvidae (family).
/// </summary>
public interface IBucorvidae
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
