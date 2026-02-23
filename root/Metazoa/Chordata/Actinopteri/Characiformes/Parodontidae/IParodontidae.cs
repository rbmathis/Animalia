namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae;

/// <summary>
/// Interface defining characteristics of Parodontidae (family).
/// </summary>
public interface IParodontidae
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
