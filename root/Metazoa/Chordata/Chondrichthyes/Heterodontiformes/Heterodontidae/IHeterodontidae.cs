namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae;

/// <summary>
/// Interface defining characteristics of Heterodontidae (family).
/// </summary>
public interface IHeterodontidae
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
