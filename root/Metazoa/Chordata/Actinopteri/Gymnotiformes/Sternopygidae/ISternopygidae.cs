namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

/// <summary>
/// Interface defining characteristics of Sternopygidae (family).
/// </summary>
public interface ISternopygidae
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
