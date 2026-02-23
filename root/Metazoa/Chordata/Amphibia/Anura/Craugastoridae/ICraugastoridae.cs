namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

/// <summary>
/// Interface defining characteristics of Craugastoridae (family).
/// </summary>
public interface ICraugastoridae
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
