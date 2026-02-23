namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinophrynidae;

/// <summary>
/// Interface defining characteristics of Rhinophrynidae (family).
/// </summary>
public interface IRhinophrynidae
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
