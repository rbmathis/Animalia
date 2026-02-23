namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae;

/// <summary>
/// Interface defining characteristics of Caenolestidae (family).
/// </summary>
public interface ICaenolestidae
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
