namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae;

/// <summary>
/// Interface defining characteristics of Spintherobolidae (family).
/// </summary>
public interface ISpintherobolidae
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
