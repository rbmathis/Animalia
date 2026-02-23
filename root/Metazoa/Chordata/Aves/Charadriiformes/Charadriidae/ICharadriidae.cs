namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

/// <summary>
/// Interface defining characteristics of Charadriidae (family).
/// </summary>
public interface ICharadriidae
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
