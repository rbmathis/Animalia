namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae;

/// <summary>
/// Interface defining characteristics of Ptychadenidae (family).
/// </summary>
public interface IPtychadenidae
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
