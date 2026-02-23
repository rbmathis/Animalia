namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae;

/// <summary>
/// Interface defining characteristics of Malapteruridae (family).
/// </summary>
public interface IMalapteruridae
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
