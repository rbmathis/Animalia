namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

/// <summary>
/// Interface defining characteristics of Hemiphractidae (family).
/// </summary>
public interface IHemiphractidae
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
