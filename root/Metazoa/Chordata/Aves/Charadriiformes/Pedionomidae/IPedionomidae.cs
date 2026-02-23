namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Pedionomidae;

/// <summary>
/// Interface defining characteristics of Pedionomidae (family).
/// </summary>
public interface IPedionomidae
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
