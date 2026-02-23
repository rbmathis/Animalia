namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Aphredoderidae;

/// <summary>
/// Interface defining characteristics of Aphredoderidae (family).
/// </summary>
public interface IAphredoderidae
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
