namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scytalinidae;

/// <summary>
/// Interface defining characteristics of Scytalinidae (family).
/// </summary>
public interface IScytalinidae
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
