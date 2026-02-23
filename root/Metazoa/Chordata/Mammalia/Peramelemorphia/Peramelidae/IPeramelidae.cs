namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae;

/// <summary>
/// Interface defining characteristics of Peramelidae (family).
/// </summary>
public interface IPeramelidae
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
