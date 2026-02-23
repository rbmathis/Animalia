namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae;

/// <summary>
/// Interface defining characteristics of Retropinnidae (family).
/// </summary>
public interface IRetropinnidae
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
