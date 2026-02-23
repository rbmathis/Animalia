namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

/// <summary>
/// Interface defining characteristics of Terapontidae (family).
/// </summary>
public interface ITerapontidae
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
