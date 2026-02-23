namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Serpenticobitidae;

/// <summary>
/// Interface defining characteristics of Serpenticobitidae (family).
/// </summary>
public interface ISerpenticobitidae
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
