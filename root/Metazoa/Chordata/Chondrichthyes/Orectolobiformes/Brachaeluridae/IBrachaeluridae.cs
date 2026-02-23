namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Brachaeluridae;

/// <summary>
/// Interface defining characteristics of Brachaeluridae (family).
/// </summary>
public interface IBrachaeluridae
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
