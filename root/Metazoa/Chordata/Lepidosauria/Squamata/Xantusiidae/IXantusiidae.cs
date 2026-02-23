namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae;

/// <summary>
/// Interface defining characteristics of Xantusiidae (family).
/// </summary>
public interface IXantusiidae
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
