namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Mitsukurinidae;

/// <summary>
/// Interface defining characteristics of Mitsukurinidae (family).
/// </summary>
public interface IMitsukurinidae
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
