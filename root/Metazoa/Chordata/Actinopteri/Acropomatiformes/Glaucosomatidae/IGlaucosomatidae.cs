namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Glaucosomatidae;

/// <summary>
/// Interface defining characteristics of Glaucosomatidae (family).
/// </summary>
public interface IGlaucosomatidae
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
