namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae;

/// <summary>
/// Interface defining characteristics of Muraenolepididae (family).
/// </summary>
public interface IMuraenolepididae
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
