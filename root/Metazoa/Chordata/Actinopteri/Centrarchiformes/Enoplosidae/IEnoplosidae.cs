namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Enoplosidae;

/// <summary>
/// Interface defining characteristics of Enoplosidae (family).
/// </summary>
public interface IEnoplosidae
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
