namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Myocastoridae;

/// <summary>
/// Interface defining characteristics of Myocastoridae (family).
/// </summary>
public interface IMyocastoridae
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
