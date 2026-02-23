namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaniolepididae;

/// <summary>
/// Interface defining characteristics of Zaniolepididae (family).
/// </summary>
public interface IZaniolepididae
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
