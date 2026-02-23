namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Gonorynchidae;

/// <summary>
/// Interface defining characteristics of Gonorynchidae (family).
/// </summary>
public interface IGonorynchidae
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
