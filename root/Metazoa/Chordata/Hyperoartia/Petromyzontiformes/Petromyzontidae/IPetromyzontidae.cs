namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

/// <summary>
/// Interface defining characteristics of Petromyzontidae (family).
/// </summary>
public interface IPetromyzontidae
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
