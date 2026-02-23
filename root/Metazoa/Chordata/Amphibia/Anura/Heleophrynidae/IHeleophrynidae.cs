namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae;

/// <summary>
/// Interface defining characteristics of Heleophrynidae (family).
/// </summary>
public interface IHeleophrynidae
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
