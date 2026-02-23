namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae;

/// <summary>
/// Interface defining characteristics of Odontobatrachidae (family).
/// </summary>
public interface IOdontobatrachidae
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
