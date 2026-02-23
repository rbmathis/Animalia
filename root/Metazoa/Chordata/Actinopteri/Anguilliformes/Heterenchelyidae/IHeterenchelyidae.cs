namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Heterenchelyidae;

/// <summary>
/// Interface defining characteristics of Heterenchelyidae (family).
/// </summary>
public interface IHeterenchelyidae
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
