namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

/// <summary>
/// Interface defining characteristics of Macrouridae (family).
/// </summary>
public interface IMacrouridae
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
