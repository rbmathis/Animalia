namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Lacantuniidae;

/// <summary>
/// Interface defining characteristics of Lacantuniidae (family).
/// </summary>
public interface ILacantuniidae
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
