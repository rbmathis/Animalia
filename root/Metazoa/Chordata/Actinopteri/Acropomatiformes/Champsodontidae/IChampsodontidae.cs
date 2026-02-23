namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae;

/// <summary>
/// Interface defining characteristics of Champsodontidae (family).
/// </summary>
public interface IChampsodontidae
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
