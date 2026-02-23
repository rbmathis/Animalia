namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae;

/// <summary>
/// Interface defining characteristics of Lepidarchidae (family).
/// </summary>
public interface ILepidarchidae
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
