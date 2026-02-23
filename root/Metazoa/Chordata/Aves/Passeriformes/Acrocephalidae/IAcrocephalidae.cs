namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acrocephalidae;

/// <summary>
/// Interface defining characteristics of Acrocephalidae (family).
/// </summary>
public interface IAcrocephalidae
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
