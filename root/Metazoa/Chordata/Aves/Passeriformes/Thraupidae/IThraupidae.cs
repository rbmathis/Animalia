namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

/// <summary>
/// Interface defining characteristics of Thraupidae (family).
/// </summary>
public interface IThraupidae
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
