namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae;

/// <summary>
/// Interface defining characteristics of Gaidropsaridae (family).
/// </summary>
public interface IGaidropsaridae
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
