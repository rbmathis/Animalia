namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Gymnarchidae;

/// <summary>
/// Interface defining characteristics of Gymnarchidae (family).
/// </summary>
public interface IGymnarchidae
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
