namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae;

/// <summary>
/// Interface defining characteristics of Branchiostomatidae (family).
/// </summary>
public interface IBranchiostomatidae
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
