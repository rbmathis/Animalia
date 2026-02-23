namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Zanclidae;

/// <summary>
/// Interface defining characteristics of Zanclidae (family).
/// </summary>
public interface IZanclidae
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
