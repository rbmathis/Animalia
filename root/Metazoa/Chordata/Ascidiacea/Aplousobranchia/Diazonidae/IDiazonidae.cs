namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae;

/// <summary>
/// Interface defining characteristics of Diazonidae (family).
/// </summary>
public interface IDiazonidae
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
