namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae;

/// <summary>
/// Interface defining characteristics of Thaumatichthyidae (family).
/// </summary>
public interface IThaumatichthyidae
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
