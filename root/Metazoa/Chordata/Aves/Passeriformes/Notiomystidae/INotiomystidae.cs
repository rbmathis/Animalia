namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Notiomystidae;

/// <summary>
/// Interface defining characteristics of Notiomystidae (family).
/// </summary>
public interface INotiomystidae
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
