namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae;

/// <summary>
/// Interface defining characteristics of Psettodidae (family).
/// </summary>
public interface IPsettodidae
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
