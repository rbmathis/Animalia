namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Daubentoniidae;

/// <summary>
/// Interface defining characteristics of Daubentoniidae (family).
/// </summary>
public interface IDaubentoniidae
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
