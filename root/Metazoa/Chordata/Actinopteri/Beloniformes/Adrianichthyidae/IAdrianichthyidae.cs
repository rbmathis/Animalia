namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae;

/// <summary>
/// Interface defining characteristics of Adrianichthyidae (family).
/// </summary>
public interface IAdrianichthyidae
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
