namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae;

/// <summary>
/// Interface defining characteristics of Cariamidae (family).
/// </summary>
public interface ICariamidae
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
