namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae;

/// <summary>
/// Interface defining characteristics of Malakichthyidae (family).
/// </summary>
public interface IMalakichthyidae
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
