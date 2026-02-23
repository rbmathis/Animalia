namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Macrosphenidae;

/// <summary>
/// Interface defining characteristics of Macrosphenidae (family).
/// </summary>
public interface IMacrosphenidae
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
