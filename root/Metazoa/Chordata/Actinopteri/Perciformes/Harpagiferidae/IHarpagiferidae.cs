namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae;

/// <summary>
/// Interface defining characteristics of Harpagiferidae (family).
/// </summary>
public interface IHarpagiferidae
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
