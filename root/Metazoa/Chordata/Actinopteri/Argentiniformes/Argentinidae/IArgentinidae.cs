namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae;

/// <summary>
/// Interface defining characteristics of Argentinidae (family).
/// </summary>
public interface IArgentinidae
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
