namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Leptosomiformes.Leptosomidae;

/// <summary>
/// Interface defining characteristics of Leptosomidae (family).
/// </summary>
public interface ILeptosomidae
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
