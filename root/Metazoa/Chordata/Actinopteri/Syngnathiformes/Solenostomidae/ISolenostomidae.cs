namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae;

/// <summary>
/// Interface defining characteristics of Solenostomidae (family).
/// </summary>
public interface ISolenostomidae
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
