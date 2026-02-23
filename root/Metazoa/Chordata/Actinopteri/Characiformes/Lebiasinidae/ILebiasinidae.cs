namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

/// <summary>
/// Interface defining characteristics of Lebiasinidae (family).
/// </summary>
public interface ILebiasinidae
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
