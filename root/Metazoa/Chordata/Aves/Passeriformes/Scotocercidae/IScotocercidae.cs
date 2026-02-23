namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Scotocercidae;

/// <summary>
/// Interface defining characteristics of Scotocercidae (family).
/// </summary>
public interface IScotocercidae
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
