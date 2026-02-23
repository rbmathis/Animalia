namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae;

/// <summary>
/// Interface defining characteristics of Potoroidae (family).
/// </summary>
public interface IPotoroidae
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
