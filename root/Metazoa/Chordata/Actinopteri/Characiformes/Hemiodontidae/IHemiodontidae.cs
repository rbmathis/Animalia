namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

/// <summary>
/// Interface defining characteristics of Hemiodontidae (family).
/// </summary>
public interface IHemiodontidae
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
