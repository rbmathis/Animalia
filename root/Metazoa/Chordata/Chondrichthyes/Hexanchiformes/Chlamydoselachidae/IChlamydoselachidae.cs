namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Chlamydoselachidae;

/// <summary>
/// Interface defining characteristics of Chlamydoselachidae (family).
/// </summary>
public interface IChlamydoselachidae
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
