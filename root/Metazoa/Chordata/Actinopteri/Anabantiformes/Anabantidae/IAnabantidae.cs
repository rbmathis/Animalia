namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

/// <summary>
/// Interface defining characteristics of Anabantidae (family).
/// </summary>
public interface IAnabantidae
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
