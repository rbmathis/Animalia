namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae;

/// <summary>
/// Interface defining characteristics of Lamnidae (family).
/// </summary>
public interface ILamnidae
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
