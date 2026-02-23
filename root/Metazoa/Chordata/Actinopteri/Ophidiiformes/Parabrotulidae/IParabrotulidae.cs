namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Parabrotulidae;

/// <summary>
/// Interface defining characteristics of Parabrotulidae (family).
/// </summary>
public interface IParabrotulidae
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
