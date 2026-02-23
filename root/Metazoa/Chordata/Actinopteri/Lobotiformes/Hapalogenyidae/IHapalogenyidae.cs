namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae;

/// <summary>
/// Interface defining characteristics of Hapalogenyidae (family).
/// </summary>
public interface IHapalogenyidae
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
