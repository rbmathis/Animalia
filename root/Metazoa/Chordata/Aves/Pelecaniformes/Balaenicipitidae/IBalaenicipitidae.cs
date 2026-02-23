namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Balaenicipitidae;

/// <summary>
/// Interface defining characteristics of Balaenicipitidae (family).
/// </summary>
public interface IBalaenicipitidae
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
