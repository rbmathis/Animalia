namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

/// <summary>
/// Interface defining characteristics of Artedidraconidae (family).
/// </summary>
public interface IArtedidraconidae
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
