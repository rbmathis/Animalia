namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Ostracoberycidae;

/// <summary>
/// Interface defining characteristics of Ostracoberycidae (family).
/// </summary>
public interface IOstracoberycidae
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
