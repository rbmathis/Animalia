namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characiformes_incertae_sedis.Tarumaniidae;

/// <summary>
/// Interface defining characteristics of Tarumaniidae (family).
/// </summary>
public interface ITarumaniidae
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
