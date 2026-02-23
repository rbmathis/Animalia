namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Tetragonuridae;

/// <summary>
/// Interface defining characteristics of Tetragonuridae (family).
/// </summary>
public interface ITetragonuridae
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
