namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

/// <summary>
/// Interface defining characteristics of Phosichthyidae (family).
/// </summary>
public interface IPhosichthyidae
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
