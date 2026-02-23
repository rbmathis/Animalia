namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Elachuridae;

/// <summary>
/// Interface defining characteristics of Elachuridae (family).
/// </summary>
public interface IElachuridae
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
