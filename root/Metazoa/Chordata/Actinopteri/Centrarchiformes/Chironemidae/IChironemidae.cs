namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Chironemidae;

/// <summary>
/// Interface defining characteristics of Chironemidae (family).
/// </summary>
public interface IChironemidae
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
