namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae;

/// <summary>
/// Interface defining characteristics of Telmatherinidae (family).
/// </summary>
public interface ITelmatherinidae
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
