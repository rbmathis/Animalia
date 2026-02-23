namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paraulopidae;

/// <summary>
/// Interface defining characteristics of Paraulopidae (family).
/// </summary>
public interface IParaulopidae
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
