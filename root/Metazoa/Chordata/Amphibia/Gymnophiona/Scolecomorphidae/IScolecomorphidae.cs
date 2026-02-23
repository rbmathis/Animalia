namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae;

/// <summary>
/// Interface defining characteristics of Scolecomorphidae (family).
/// </summary>
public interface IScolecomorphidae
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
