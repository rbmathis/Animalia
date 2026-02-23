namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae;

/// <summary>
/// Interface defining characteristics of Bregmacerotidae (family).
/// </summary>
public interface IBregmacerotidae
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
