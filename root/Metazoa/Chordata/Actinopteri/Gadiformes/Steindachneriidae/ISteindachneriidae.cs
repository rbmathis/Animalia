namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Steindachneriidae;

/// <summary>
/// Interface defining characteristics of Steindachneriidae (family).
/// </summary>
public interface ISteindachneriidae
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
