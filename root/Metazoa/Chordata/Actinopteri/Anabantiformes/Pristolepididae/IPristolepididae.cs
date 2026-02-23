namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Pristolepididae;

/// <summary>
/// Interface defining characteristics of Pristolepididae (family).
/// </summary>
public interface IPristolepididae
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
