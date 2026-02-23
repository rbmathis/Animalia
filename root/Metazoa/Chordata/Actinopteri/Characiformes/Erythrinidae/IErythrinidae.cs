namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae;

/// <summary>
/// Interface defining characteristics of Erythrinidae (family).
/// </summary>
public interface IErythrinidae
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
