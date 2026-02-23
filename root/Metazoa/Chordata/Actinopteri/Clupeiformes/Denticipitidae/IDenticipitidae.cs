namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Denticipitidae;

/// <summary>
/// Interface defining characteristics of Denticipitidae (family).
/// </summary>
public interface IDenticipitidae
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
