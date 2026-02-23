namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Giganturidae;

/// <summary>
/// Interface defining characteristics of Giganturidae (family).
/// </summary>
public interface IGiganturidae
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
