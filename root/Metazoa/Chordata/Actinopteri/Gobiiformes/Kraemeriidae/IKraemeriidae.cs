namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae;

/// <summary>
/// Interface defining characteristics of Kraemeriidae (family).
/// </summary>
public interface IKraemeriidae
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
