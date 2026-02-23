namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae;

/// <summary>
/// Interface defining characteristics of Vombatidae (family).
/// </summary>
public interface IVombatidae
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
