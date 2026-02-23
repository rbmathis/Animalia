namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae;

/// <summary>
/// Interface defining characteristics of Pardalotidae (family).
/// </summary>
public interface IPardalotidae
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
