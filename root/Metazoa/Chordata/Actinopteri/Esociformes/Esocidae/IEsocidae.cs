namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae;

/// <summary>
/// Interface defining characteristics of Esocidae (family).
/// </summary>
public interface IEsocidae
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
