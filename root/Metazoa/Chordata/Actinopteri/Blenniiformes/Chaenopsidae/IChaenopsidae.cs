namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

/// <summary>
/// Interface defining characteristics of Chaenopsidae (family).
/// </summary>
public interface IChaenopsidae
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
