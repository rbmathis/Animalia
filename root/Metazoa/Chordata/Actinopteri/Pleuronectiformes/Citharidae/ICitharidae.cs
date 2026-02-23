namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae;

/// <summary>
/// Interface defining characteristics of Citharidae (family).
/// </summary>
public interface ICitharidae
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
