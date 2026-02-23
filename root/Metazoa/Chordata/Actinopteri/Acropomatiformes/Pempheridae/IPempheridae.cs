namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae;

/// <summary>
/// Interface defining characteristics of Pempheridae (family).
/// </summary>
public interface IPempheridae
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
