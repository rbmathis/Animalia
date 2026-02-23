namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

/// <summary>
/// Interface defining characteristics of Zosteropidae (family).
/// </summary>
public interface IZosteropidae
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
