namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

/// <summary>
/// Interface defining characteristics of Fringillidae (family).
/// </summary>
public interface IFringillidae
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
