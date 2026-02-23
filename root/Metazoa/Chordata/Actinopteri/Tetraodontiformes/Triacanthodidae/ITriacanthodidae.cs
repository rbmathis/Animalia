namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

/// <summary>
/// Interface defining characteristics of Triacanthodidae (family).
/// </summary>
public interface ITriacanthodidae
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
