namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae;

/// <summary>
/// Interface defining characteristics of Derichthyidae (family).
/// </summary>
public interface IDerichthyidae
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
