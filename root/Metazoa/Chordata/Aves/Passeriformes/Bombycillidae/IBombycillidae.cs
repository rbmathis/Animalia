namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae;

/// <summary>
/// Interface defining characteristics of Bombycillidae (family).
/// </summary>
public interface IBombycillidae
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
