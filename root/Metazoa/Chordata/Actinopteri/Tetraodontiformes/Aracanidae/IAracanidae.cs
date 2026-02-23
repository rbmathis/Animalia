namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae;

/// <summary>
/// Interface defining characteristics of Aracanidae (family).
/// </summary>
public interface IAracanidae
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
