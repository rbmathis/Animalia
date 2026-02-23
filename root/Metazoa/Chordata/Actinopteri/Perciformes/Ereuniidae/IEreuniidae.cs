namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ereuniidae;

/// <summary>
/// Interface defining characteristics of Ereuniidae (family).
/// </summary>
public interface IEreuniidae
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
