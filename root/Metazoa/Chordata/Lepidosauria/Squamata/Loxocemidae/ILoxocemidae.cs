namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Loxocemidae;

/// <summary>
/// Interface defining characteristics of Loxocemidae (family).
/// </summary>
public interface ILoxocemidae
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
