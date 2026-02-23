namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

/// <summary>
/// Interface defining characteristics of Paralepididae (family).
/// </summary>
public interface IParalepididae
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
