namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae;

/// <summary>
/// Interface defining characteristics of Brachionichthyidae (family).
/// </summary>
public interface IBrachionichthyidae
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
