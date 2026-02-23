namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae;

/// <summary>
/// Interface defining characteristics of Chirocentridae (family).
/// </summary>
public interface IChirocentridae
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
