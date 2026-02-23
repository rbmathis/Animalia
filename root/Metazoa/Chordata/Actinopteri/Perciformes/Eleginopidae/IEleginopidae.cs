namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Eleginopidae;

/// <summary>
/// Interface defining characteristics of Eleginopidae (family).
/// </summary>
public interface IEleginopidae
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
