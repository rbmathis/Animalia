namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

/// <summary>
/// Interface defining characteristics of Cisticolidae (family).
/// </summary>
public interface ICisticolidae
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
