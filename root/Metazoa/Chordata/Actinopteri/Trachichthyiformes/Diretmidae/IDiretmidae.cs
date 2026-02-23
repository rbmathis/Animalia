namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae;

/// <summary>
/// Interface defining characteristics of Diretmidae (family).
/// </summary>
public interface IDiretmidae
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
