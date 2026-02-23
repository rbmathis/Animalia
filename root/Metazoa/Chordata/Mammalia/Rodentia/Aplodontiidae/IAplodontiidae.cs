namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Aplodontiidae;

/// <summary>
/// Interface defining characteristics of Aplodontiidae (family).
/// </summary>
public interface IAplodontiidae
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
