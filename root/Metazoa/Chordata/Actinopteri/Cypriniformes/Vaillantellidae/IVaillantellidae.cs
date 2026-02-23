namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Vaillantellidae;

/// <summary>
/// Interface defining characteristics of Vaillantellidae (family).
/// </summary>
public interface IVaillantellidae
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
