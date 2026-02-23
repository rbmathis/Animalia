namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

/// <summary>
/// Interface defining characteristics of Nototheniidae (family).
/// </summary>
public interface INototheniidae
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
