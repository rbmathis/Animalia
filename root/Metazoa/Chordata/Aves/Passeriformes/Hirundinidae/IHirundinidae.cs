namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

/// <summary>
/// Interface defining characteristics of Hirundinidae (family).
/// </summary>
public interface IHirundinidae
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
