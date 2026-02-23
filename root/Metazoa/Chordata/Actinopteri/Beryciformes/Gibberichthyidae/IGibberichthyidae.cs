namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Gibberichthyidae;

/// <summary>
/// Interface defining characteristics of Gibberichthyidae (family).
/// </summary>
public interface IGibberichthyidae
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
