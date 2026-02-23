namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae;

/// <summary>
/// Interface defining characteristics of Nasikabatrachidae (family).
/// </summary>
public interface INasikabatrachidae
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
