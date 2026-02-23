namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Orthonychidae;

/// <summary>
/// Interface defining characteristics of Orthonychidae (family).
/// </summary>
public interface IOrthonychidae
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
