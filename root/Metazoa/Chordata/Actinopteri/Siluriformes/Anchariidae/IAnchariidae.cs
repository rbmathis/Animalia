namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae;

/// <summary>
/// Interface defining characteristics of Anchariidae (family).
/// </summary>
public interface IAnchariidae
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
