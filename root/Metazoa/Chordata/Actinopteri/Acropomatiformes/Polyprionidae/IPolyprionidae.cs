namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae;

/// <summary>
/// Interface defining characteristics of Polyprionidae (family).
/// </summary>
public interface IPolyprionidae
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
