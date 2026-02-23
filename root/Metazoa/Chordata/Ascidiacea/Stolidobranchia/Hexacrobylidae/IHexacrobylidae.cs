namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Hexacrobylidae;

/// <summary>
/// Interface defining characteristics of Hexacrobylidae (family).
/// </summary>
public interface IHexacrobylidae
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
