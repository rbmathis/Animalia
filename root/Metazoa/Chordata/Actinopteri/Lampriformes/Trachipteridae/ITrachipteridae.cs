namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae;

/// <summary>
/// Interface defining characteristics of Trachipteridae (family).
/// </summary>
public interface ITrachipteridae
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
