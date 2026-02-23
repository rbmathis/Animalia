namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Philepittidae;

/// <summary>
/// Interface defining characteristics of Philepittidae (family).
/// </summary>
public interface IPhilepittidae
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
