namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae;

/// <summary>
/// Interface defining characteristics of Hoplichthyidae (family).
/// </summary>
public interface IHoplichthyidae
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
