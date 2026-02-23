namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Helostomatidae;

/// <summary>
/// Interface defining characteristics of Helostomatidae (family).
/// </summary>
public interface IHelostomatidae
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
