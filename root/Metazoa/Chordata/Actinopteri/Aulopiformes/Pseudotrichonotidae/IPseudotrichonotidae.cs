namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Pseudotrichonotidae;

/// <summary>
/// Interface defining characteristics of Pseudotrichonotidae (family).
/// </summary>
public interface IPseudotrichonotidae
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
