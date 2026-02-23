namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae;

/// <summary>
/// Interface defining characteristics of Trichonotidae (family).
/// </summary>
public interface ITrichonotidae
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
