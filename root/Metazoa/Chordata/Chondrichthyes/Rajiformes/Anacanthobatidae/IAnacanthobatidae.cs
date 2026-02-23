namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Anacanthobatidae;

/// <summary>
/// Interface defining characteristics of Anacanthobatidae (family).
/// </summary>
public interface IAnacanthobatidae
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
