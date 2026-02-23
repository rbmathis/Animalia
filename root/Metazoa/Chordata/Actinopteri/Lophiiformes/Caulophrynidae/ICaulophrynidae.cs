namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Caulophrynidae;

/// <summary>
/// Interface defining characteristics of Caulophrynidae (family).
/// </summary>
public interface ICaulophrynidae
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
