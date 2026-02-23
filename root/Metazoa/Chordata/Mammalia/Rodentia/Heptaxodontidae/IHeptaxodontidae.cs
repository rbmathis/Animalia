namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heptaxodontidae;

/// <summary>
/// Interface defining characteristics of Heptaxodontidae (family).
/// </summary>
public interface IHeptaxodontidae
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
