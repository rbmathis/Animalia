namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Hexanchidae;

/// <summary>
/// Interface defining characteristics of Hexanchidae (family).
/// </summary>
public interface IHexanchidae
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
