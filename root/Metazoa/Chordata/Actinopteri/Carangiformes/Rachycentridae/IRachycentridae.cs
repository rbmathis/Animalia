namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae;

/// <summary>
/// Interface defining characteristics of Rachycentridae (family).
/// </summary>
public interface IRachycentridae
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
