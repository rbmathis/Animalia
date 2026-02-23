namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae;

/// <summary>
/// Interface defining characteristics of Amblycipitidae (family).
/// </summary>
public interface IAmblycipitidae
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
