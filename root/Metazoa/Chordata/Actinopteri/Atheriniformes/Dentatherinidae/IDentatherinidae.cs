namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Dentatherinidae;

/// <summary>
/// Interface defining characteristics of Dentatherinidae (family).
/// </summary>
public interface IDentatherinidae
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
