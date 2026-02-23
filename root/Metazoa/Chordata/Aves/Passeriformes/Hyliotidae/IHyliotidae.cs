namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hyliotidae;

/// <summary>
/// Interface defining characteristics of Hyliotidae (family).
/// </summary>
public interface IHyliotidae
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
