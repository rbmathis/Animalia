namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenosauridae;

/// <summary>
/// Interface defining characteristics of Xenosauridae (family).
/// </summary>
public interface IXenosauridae
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
