namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Aenigmachannidae;

/// <summary>
/// Interface defining characteristics of Aenigmachannidae (family).
/// </summary>
public interface IAenigmachannidae
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
