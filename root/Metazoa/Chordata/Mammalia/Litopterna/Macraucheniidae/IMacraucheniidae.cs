namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae;

/// <summary>
/// Interface defining characteristics of Macraucheniidae (family).
/// </summary>
public interface IMacraucheniidae
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
