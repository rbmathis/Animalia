namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cylindrophiidae;

/// <summary>
/// Interface defining characteristics of Cylindrophiidae (family).
/// </summary>
public interface ICylindrophiidae
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
