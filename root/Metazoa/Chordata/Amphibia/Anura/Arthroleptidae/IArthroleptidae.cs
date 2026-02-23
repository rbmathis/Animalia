namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

/// <summary>
/// Interface defining characteristics of Arthroleptidae (family).
/// </summary>
public interface IArthroleptidae
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
