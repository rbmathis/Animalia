namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lanthanotidae;

/// <summary>
/// Interface defining characteristics of Lanthanotidae (family).
/// </summary>
public interface ILanthanotidae
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
