namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Barbourisiidae;

/// <summary>
/// Interface defining characteristics of Barbourisiidae (family).
/// </summary>
public interface IBarbourisiidae
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
