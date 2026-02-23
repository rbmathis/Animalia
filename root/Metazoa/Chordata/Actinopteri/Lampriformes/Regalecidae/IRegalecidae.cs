namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Regalecidae;

/// <summary>
/// Interface defining characteristics of Regalecidae (family).
/// </summary>
public interface IRegalecidae
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
