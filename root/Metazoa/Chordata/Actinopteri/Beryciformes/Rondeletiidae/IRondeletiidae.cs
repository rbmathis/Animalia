namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae;

/// <summary>
/// Interface defining characteristics of Rondeletiidae (family).
/// </summary>
public interface IRondeletiidae
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
