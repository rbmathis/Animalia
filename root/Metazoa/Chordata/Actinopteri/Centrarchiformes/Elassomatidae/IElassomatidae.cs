namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Elassomatidae;

/// <summary>
/// Interface defining characteristics of Elassomatidae (family).
/// </summary>
public interface IElassomatidae
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
