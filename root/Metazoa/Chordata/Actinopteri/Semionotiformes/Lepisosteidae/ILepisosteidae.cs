namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae;

/// <summary>
/// Interface defining characteristics of Lepisosteidae (family).
/// </summary>
public interface ILepisosteidae
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
