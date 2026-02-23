namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

/// <summary>
/// Interface defining characteristics of Strabomantidae (family).
/// </summary>
public interface IStrabomantidae
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
