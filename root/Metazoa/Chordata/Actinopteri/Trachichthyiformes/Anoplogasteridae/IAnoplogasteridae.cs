namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anoplogasteridae;

/// <summary>
/// Interface defining characteristics of Anoplogasteridae (family).
/// </summary>
public interface IAnoplogasteridae
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
