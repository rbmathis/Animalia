namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

/// <summary>
/// Interface defining characteristics of Priacanthidae (family).
/// </summary>
public interface IPriacanthidae
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
