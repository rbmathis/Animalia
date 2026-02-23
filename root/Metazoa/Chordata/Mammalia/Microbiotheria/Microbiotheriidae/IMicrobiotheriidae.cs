namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Microbiotheria.Microbiotheriidae;

/// <summary>
/// Interface defining characteristics of Microbiotheriidae (family).
/// </summary>
public interface IMicrobiotheriidae
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
