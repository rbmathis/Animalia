namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Plesiobatidae;

/// <summary>
/// Interface defining characteristics of Plesiobatidae (family).
/// </summary>
public interface IPlesiobatidae
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
