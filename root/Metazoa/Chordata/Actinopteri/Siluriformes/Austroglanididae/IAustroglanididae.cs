namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Austroglanididae;

/// <summary>
/// Interface defining characteristics of Austroglanididae (family).
/// </summary>
public interface IAustroglanididae
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
