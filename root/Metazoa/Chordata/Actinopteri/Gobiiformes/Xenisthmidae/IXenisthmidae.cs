namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae;

/// <summary>
/// Interface defining characteristics of Xenisthmidae (family).
/// </summary>
public interface IXenisthmidae
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
