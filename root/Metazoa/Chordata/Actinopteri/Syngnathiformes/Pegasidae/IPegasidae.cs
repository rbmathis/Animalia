namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae;

/// <summary>
/// Interface defining characteristics of Pegasidae (family).
/// </summary>
public interface IPegasidae
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
