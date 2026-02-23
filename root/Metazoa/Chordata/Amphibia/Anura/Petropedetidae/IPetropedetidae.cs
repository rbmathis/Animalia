namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae;

/// <summary>
/// Interface defining characteristics of Petropedetidae (family).
/// </summary>
public interface IPetropedetidae
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
