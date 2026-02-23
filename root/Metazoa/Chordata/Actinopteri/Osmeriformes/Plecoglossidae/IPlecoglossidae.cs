namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Plecoglossidae;

/// <summary>
/// Interface defining characteristics of Plecoglossidae (family).
/// </summary>
public interface IPlecoglossidae
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
