namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Xiphiidae;

/// <summary>
/// Interface defining characteristics of Xiphiidae (family).
/// </summary>
public interface IXiphiidae
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
