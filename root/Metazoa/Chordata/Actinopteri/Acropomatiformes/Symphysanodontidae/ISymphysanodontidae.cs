namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae;

/// <summary>
/// Interface defining characteristics of Symphysanodontidae (family).
/// </summary>
public interface ISymphysanodontidae
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
