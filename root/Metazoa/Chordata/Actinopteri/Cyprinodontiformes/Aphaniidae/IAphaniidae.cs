namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

/// <summary>
/// Interface defining characteristics of Aphaniidae (family).
/// </summary>
public interface IAphaniidae
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
