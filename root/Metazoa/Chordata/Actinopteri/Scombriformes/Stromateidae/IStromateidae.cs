namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae;

/// <summary>
/// Interface defining characteristics of Stromateidae (family).
/// </summary>
public interface IStromateidae
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
