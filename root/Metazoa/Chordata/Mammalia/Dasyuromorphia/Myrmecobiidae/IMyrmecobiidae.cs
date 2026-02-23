namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Myrmecobiidae;

/// <summary>
/// Interface defining characteristics of Myrmecobiidae (family).
/// </summary>
public interface IMyrmecobiidae
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
