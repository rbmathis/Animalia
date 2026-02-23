namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hepsetidae;

/// <summary>
/// Interface defining characteristics of Hepsetidae (family).
/// </summary>
public interface IHepsetidae
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
