namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

/// <summary>
/// Interface defining characteristics of Chlopsidae (family).
/// </summary>
public interface IChlopsidae
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
