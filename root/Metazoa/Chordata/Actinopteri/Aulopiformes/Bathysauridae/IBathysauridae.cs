namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauridae;

/// <summary>
/// Interface defining characteristics of Bathysauridae (family).
/// </summary>
public interface IBathysauridae
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
