namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pseudodistomidae;

/// <summary>
/// Interface defining characteristics of Pseudodistomidae (family).
/// </summary>
public interface IPseudodistomidae
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
