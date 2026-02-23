namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae;

/// <summary>
/// Interface defining characteristics of Dactylopteridae (family).
/// </summary>
public interface IDactylopteridae
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
