namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Oxynotidae;

/// <summary>
/// Interface defining characteristics of Oxynotidae (family).
/// </summary>
public interface IOxynotidae
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
