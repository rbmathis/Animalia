namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stylephoriformes.Stylephoridae;

/// <summary>
/// Interface defining characteristics of Stylephoridae (family).
/// </summary>
public interface IStylephoridae
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
