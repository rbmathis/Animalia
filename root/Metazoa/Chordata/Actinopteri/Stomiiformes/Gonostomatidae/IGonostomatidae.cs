namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

/// <summary>
/// Interface defining characteristics of Gonostomatidae (family).
/// </summary>
public interface IGonostomatidae
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
