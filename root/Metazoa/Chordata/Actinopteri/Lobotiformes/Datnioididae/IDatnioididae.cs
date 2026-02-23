namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Datnioididae;

/// <summary>
/// Interface defining characteristics of Datnioididae (family).
/// </summary>
public interface IDatnioididae
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
