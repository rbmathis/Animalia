namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae;

/// <summary>
/// Interface defining characteristics of Lateolabracidae (family).
/// </summary>
public interface ILateolabracidae
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
