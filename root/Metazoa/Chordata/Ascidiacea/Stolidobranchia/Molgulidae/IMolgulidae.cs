namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae;

/// <summary>
/// Interface defining characteristics of Molgulidae (family).
/// </summary>
public interface IMolgulidae
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
