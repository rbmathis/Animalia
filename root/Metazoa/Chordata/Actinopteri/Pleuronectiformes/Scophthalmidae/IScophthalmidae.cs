namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae;

/// <summary>
/// Interface defining characteristics of Scophthalmidae (family).
/// </summary>
public interface IScophthalmidae
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
