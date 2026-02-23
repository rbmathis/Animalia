namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hypoptychidae;

/// <summary>
/// Interface defining characteristics of Hypoptychidae (family).
/// </summary>
public interface IHypoptychidae
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
