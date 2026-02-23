namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae;

/// <summary>
/// Interface defining characteristics of Leptobarbidae (family).
/// </summary>
public interface ILeptobarbidae
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
