namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anarhichadidae;

/// <summary>
/// Interface defining characteristics of Anarhichadidae (family).
/// </summary>
public interface IAnarhichadidae
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
