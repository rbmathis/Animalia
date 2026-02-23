namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae;

/// <summary>
/// Interface defining characteristics of Chaudhuriidae (family).
/// </summary>
public interface IChaudhuriidae
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
