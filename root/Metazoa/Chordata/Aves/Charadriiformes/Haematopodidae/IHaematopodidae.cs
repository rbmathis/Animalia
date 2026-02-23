namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Haematopodidae;

/// <summary>
/// Interface defining characteristics of Haematopodidae (family).
/// </summary>
public interface IHaematopodidae
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
