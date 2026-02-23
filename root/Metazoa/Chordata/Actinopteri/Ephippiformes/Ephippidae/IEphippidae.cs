namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

/// <summary>
/// Interface defining characteristics of Ephippidae (family).
/// </summary>
public interface IEphippidae
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
