namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae;

/// <summary>
/// Interface defining characteristics of Lethrinidae (family).
/// </summary>
public interface ILethrinidae
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
