namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae;

/// <summary>
/// Interface defining characteristics of Burramyidae (family).
/// </summary>
public interface IBurramyidae
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
