namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae;

/// <summary>
/// Interface defining characteristics of Brachypteraciidae (family).
/// </summary>
public interface IBrachypteraciidae
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
