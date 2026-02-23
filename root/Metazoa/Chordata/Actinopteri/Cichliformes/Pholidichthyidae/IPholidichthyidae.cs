namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae;

/// <summary>
/// Interface defining characteristics of Pholidichthyidae (family).
/// </summary>
public interface IPholidichthyidae
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
