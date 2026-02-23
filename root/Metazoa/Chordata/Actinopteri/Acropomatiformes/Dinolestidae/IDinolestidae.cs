namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Dinolestidae;

/// <summary>
/// Interface defining characteristics of Dinolestidae (family).
/// </summary>
public interface IDinolestidae
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
