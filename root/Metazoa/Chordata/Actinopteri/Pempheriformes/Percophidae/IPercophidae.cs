namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

/// <summary>
/// Interface defining characteristics of Percophidae (family).
/// </summary>
public interface IPercophidae
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
