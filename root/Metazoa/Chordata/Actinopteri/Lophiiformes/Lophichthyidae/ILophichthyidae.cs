namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophichthyidae;

/// <summary>
/// Interface defining characteristics of Lophichthyidae (family).
/// </summary>
public interface ILophichthyidae
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
