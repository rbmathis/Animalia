namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae;

/// <summary>
/// Interface defining characteristics of Cryptobranchidae (family).
/// </summary>
public interface ICryptobranchidae
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
