namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae;

/// <summary>
/// Interface defining characteristics of Corellidae (family).
/// </summary>
public interface ICorellidae
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
