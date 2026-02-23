namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

/// <summary>
/// Interface defining characteristics of Leptodactylidae (family).
/// </summary>
public interface ILeptodactylidae
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
