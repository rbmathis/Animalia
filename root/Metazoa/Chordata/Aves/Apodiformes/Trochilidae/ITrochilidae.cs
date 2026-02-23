namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

/// <summary>
/// Interface defining characteristics of Trochilidae (family).
/// </summary>
public interface ITrochilidae
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
