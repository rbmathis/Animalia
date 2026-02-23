namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

/// <summary>
/// Interface defining characteristics of Indotyphlidae (family).
/// </summary>
public interface IIndotyphlidae
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
