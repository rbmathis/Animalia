namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae;

/// <summary>
/// Interface defining characteristics of Leptoscopidae (family).
/// </summary>
public interface ILeptoscopidae
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
