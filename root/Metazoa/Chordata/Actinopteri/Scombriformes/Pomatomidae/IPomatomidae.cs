namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Pomatomidae;

/// <summary>
/// Interface defining characteristics of Pomatomidae (family).
/// </summary>
public interface IPomatomidae
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
