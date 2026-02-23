namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Radiicephalidae;

/// <summary>
/// Interface defining characteristics of Radiicephalidae (family).
/// </summary>
public interface IRadiicephalidae
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
