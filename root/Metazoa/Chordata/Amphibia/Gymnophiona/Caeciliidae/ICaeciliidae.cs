namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae;

/// <summary>
/// Interface defining characteristics of Caeciliidae (family).
/// </summary>
public interface ICaeciliidae
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
