namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae;

/// <summary>
/// Interface defining characteristics of Ellopostomatidae (family).
/// </summary>
public interface IEllopostomatidae
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
