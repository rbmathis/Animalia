namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae;

/// <summary>
/// Interface defining characteristics of Picathartidae (family).
/// </summary>
public interface IPicathartidae
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
