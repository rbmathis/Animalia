namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae;

/// <summary>
/// Interface defining characteristics of Pataecidae (family).
/// </summary>
public interface IPataecidae
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
