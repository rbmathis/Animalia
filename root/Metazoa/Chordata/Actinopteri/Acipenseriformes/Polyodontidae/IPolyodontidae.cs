namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae;

/// <summary>
/// Interface defining characteristics of Polyodontidae (family).
/// </summary>
public interface IPolyodontidae
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
