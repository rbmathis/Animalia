namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae;

/// <summary>
/// Interface defining characteristics of Fritillariidae (family).
/// </summary>
public interface IFritillariidae
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
