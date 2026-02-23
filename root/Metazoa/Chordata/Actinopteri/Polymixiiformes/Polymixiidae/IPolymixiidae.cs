namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae;

/// <summary>
/// Interface defining characteristics of Polymixiidae (family).
/// </summary>
public interface IPolymixiidae
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
