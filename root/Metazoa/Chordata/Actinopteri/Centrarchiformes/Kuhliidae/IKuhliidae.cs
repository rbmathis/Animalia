namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae;

/// <summary>
/// Interface defining characteristics of Kuhliidae (family).
/// </summary>
public interface IKuhliidae
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
