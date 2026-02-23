namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cranoglanididae;

/// <summary>
/// Interface defining characteristics of Cranoglanididae (family).
/// </summary>
public interface ICranoglanididae
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
