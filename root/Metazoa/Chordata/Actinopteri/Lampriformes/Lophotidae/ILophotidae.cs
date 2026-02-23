namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lophotidae;

/// <summary>
/// Interface defining characteristics of Lophotidae (family).
/// </summary>
public interface ILophotidae
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
