namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

/// <summary>
/// Interface defining characteristics of Estrildidae (family).
/// </summary>
public interface IEstrildidae
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
