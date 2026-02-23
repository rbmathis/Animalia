namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

/// <summary>
/// Interface defining characteristics of Centrolophidae (family).
/// </summary>
public interface ICentrolophidae
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
