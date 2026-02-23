namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae;

/// <summary>
/// Interface defining characteristics of Melanocharitidae (family).
/// </summary>
public interface IMelanocharitidae
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
