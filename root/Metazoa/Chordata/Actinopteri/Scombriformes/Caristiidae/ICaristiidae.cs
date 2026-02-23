namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae;

/// <summary>
/// Interface defining characteristics of Caristiidae (family).
/// </summary>
public interface ICaristiidae
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
