namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Luvaridae;

/// <summary>
/// Interface defining characteristics of Luvaridae (family).
/// </summary>
public interface ILuvaridae
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
