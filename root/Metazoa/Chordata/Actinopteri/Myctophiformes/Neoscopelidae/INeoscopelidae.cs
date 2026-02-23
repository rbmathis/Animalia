namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae;

/// <summary>
/// Interface defining characteristics of Neoscopelidae (family).
/// </summary>
public interface INeoscopelidae
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
