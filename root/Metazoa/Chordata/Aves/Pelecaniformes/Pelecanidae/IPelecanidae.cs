namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae;

/// <summary>
/// Interface defining characteristics of Pelecanidae (family).
/// </summary>
public interface IPelecanidae
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
