namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ptilichthyidae;

/// <summary>
/// Interface defining characteristics of Ptilichthyidae (family).
/// </summary>
public interface IPtilichthyidae
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
