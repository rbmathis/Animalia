namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauropsidae;

/// <summary>
/// Interface defining characteristics of Bathysauropsidae (family).
/// </summary>
public interface IBathysauropsidae
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
