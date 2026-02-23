namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae;

/// <summary>
/// Interface defining characteristics of Glareolidae (family).
/// </summary>
public interface IGlareolidae
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
