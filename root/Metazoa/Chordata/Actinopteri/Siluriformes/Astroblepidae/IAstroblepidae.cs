namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae;

/// <summary>
/// Interface defining characteristics of Astroblepidae (family).
/// </summary>
public interface IAstroblepidae
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
