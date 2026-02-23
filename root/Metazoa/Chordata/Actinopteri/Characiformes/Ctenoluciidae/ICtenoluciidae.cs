namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae;

/// <summary>
/// Interface defining characteristics of Ctenoluciidae (family).
/// </summary>
public interface ICtenoluciidae
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
