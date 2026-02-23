namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae;

/// <summary>
/// Interface defining characteristics of Neblinaphrynidae (family).
/// </summary>
public interface INeblinaphrynidae
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
