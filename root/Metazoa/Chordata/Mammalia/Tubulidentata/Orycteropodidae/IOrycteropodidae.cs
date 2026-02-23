namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae;

/// <summary>
/// Interface defining characteristics of Orycteropodidae (family).
/// </summary>
public interface IOrycteropodidae
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
