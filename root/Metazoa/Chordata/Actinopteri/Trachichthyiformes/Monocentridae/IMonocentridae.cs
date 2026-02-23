namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae;

/// <summary>
/// Interface defining characteristics of Monocentridae (family).
/// </summary>
public interface IMonocentridae
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
