namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae;

/// <summary>
/// Interface defining characteristics of Aplodactylidae (family).
/// </summary>
public interface IAplodactylidae
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
