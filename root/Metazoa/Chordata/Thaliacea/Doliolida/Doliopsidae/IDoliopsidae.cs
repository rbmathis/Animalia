namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliopsidae;

/// <summary>
/// Interface defining characteristics of Doliopsidae (family).
/// </summary>
public interface IDoliopsidae
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
