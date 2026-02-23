namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Arripidae;

/// <summary>
/// Interface defining characteristics of Arripidae (family).
/// </summary>
public interface IArripidae
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
