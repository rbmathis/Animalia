namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae;

/// <summary>
/// Interface defining characteristics of Sinipercidae (family).
/// </summary>
public interface ISinipercidae
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
