namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae;

/// <summary>
/// Interface defining characteristics of Gyrinocheilidae (family).
/// </summary>
public interface IGyrinocheilidae
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
