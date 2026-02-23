namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae;

/// <summary>
/// Interface defining characteristics of Osteoglossidae (family).
/// </summary>
public interface IOsteoglossidae
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
