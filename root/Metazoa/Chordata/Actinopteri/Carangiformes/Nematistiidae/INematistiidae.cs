namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Nematistiidae;

/// <summary>
/// Interface defining characteristics of Nematistiidae (family).
/// </summary>
public interface INematistiidae
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
