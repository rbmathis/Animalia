namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Pantodontidae;

/// <summary>
/// Interface defining characteristics of Pantodontidae (family).
/// </summary>
public interface IPantodontidae
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
