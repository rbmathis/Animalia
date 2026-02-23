namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

/// <summary>
/// Interface defining characteristics of Achiridae (family).
/// </summary>
public interface IAchiridae
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
