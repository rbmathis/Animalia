namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Dichistiidae;

/// <summary>
/// Interface defining characteristics of Dichistiidae (family).
/// </summary>
public interface IDichistiidae
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
