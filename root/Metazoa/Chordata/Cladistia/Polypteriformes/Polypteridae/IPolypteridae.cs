namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae;

/// <summary>
/// Interface defining characteristics of Polypteridae (family).
/// </summary>
public interface IPolypteridae
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
