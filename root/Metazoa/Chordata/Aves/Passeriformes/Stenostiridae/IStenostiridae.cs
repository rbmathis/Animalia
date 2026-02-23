namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae;

/// <summary>
/// Interface defining characteristics of Stenostiridae (family).
/// </summary>
public interface IStenostiridae
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
