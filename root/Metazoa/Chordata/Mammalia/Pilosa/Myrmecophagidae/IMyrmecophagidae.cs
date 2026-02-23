namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae;

/// <summary>
/// Interface defining characteristics of Myrmecophagidae (family).
/// </summary>
public interface IMyrmecophagidae
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
