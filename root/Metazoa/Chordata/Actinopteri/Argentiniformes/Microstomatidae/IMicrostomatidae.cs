namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae;

/// <summary>
/// Interface defining characteristics of Microstomatidae (family).
/// </summary>
public interface IMicrostomatidae
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
