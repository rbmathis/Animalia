namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae;

/// <summary>
/// Interface defining characteristics of Coraciidae (family).
/// </summary>
public interface ICoraciidae
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
