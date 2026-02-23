namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

/// <summary>
/// Interface defining characteristics of Leiothrichidae (family).
/// </summary>
public interface ILeiothrichidae
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
