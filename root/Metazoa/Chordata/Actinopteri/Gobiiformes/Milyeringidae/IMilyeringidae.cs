namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Milyeringidae;

/// <summary>
/// Interface defining characteristics of Milyeringidae (family).
/// </summary>
public interface IMilyeringidae
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
