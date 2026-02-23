namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Hiodontiformes.Hiodontidae;

/// <summary>
/// Interface defining characteristics of Hiodontidae (family).
/// </summary>
public interface IHiodontidae
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
