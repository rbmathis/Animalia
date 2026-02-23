namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

/// <summary>
/// Interface defining characteristics of Nectariniidae (family).
/// </summary>
public interface INectariniidae
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
