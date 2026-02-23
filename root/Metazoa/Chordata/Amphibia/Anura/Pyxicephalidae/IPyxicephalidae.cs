namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

/// <summary>
/// Interface defining characteristics of Pyxicephalidae (family).
/// </summary>
public interface IPyxicephalidae
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
