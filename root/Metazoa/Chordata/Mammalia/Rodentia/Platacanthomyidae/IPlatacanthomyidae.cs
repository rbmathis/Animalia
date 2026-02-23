namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae;

/// <summary>
/// Interface defining characteristics of Platacanthomyidae (family).
/// </summary>
public interface IPlatacanthomyidae
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
