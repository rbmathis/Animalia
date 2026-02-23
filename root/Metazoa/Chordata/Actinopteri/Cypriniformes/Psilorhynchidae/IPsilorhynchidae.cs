namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae;

/// <summary>
/// Interface defining characteristics of Psilorhynchidae (family).
/// </summary>
public interface IPsilorhynchidae
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
