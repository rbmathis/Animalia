namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

/// <summary>
/// Interface defining characteristics of Passerellidae (family).
/// </summary>
public interface IPasserellidae
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
