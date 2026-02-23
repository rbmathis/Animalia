namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Synoicidae;

/// <summary>
/// Interface defining characteristics of Synoicidae (family).
/// </summary>
public interface ISynoicidae
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
