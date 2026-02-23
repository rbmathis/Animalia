namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae;

/// <summary>
/// Interface defining characteristics of Pseudomugilidae (family).
/// </summary>
public interface IPseudomugilidae
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
