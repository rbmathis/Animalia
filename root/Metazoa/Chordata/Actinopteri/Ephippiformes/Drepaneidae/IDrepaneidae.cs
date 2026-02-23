namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Drepaneidae;

/// <summary>
/// Interface defining characteristics of Drepaneidae (family).
/// </summary>
public interface IDrepaneidae
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
