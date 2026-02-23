namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

/// <summary>
/// Interface defining characteristics of Muraenidae (family).
/// </summary>
public interface IMuraenidae
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
