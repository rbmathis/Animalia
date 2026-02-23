namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae;

/// <summary>
/// Interface defining characteristics of Centrophoridae (family).
/// </summary>
public interface ICentrophoridae
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
