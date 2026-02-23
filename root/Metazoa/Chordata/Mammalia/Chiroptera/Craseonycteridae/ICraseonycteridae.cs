namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Craseonycteridae;

/// <summary>
/// Interface defining characteristics of Craseonycteridae (family).
/// </summary>
public interface ICraseonycteridae
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
