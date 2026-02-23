namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae;

/// <summary>
/// Interface defining characteristics of Scombropidae (family).
/// </summary>
public interface IScombropidae
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
