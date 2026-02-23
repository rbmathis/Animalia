namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae;

/// <summary>
/// Interface defining characteristics of Citharinidae (family).
/// </summary>
public interface ICitharinidae
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
