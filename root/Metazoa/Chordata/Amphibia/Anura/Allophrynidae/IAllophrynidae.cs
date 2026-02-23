namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Allophrynidae;

/// <summary>
/// Interface defining characteristics of Allophrynidae (family).
/// </summary>
public interface IAllophrynidae
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
