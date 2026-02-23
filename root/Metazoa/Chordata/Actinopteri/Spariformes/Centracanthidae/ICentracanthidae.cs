namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae;

/// <summary>
/// Interface defining characteristics of Centracanthidae (family).
/// </summary>
public interface ICentracanthidae
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
