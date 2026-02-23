namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae;

/// <summary>
/// Interface defining characteristics of Peristediidae (family).
/// </summary>
public interface IPeristediidae
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
