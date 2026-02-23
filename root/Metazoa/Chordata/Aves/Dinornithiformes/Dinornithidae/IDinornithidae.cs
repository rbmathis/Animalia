namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae;

/// <summary>
/// Interface defining characteristics of Dinornithidae (family).
/// </summary>
public interface IDinornithidae
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
