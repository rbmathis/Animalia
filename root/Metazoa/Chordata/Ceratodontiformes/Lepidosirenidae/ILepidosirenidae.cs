namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae;

/// <summary>
/// Interface defining characteristics of Lepidosirenidae (family).
/// </summary>
public interface ILepidosirenidae
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
