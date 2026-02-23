namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae;

/// <summary>
/// Interface defining characteristics of Zenarchopteridae (family).
/// </summary>
public interface IZenarchopteridae
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
