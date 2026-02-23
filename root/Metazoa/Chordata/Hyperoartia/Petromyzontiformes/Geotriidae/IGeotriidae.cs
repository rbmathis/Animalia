namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Geotriidae;

/// <summary>
/// Interface defining characteristics of Geotriidae (family).
/// </summary>
public interface IGeotriidae
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
