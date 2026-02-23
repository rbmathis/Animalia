namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

/// <summary>
/// Interface defining characteristics of Oikopleuridae (family).
/// </summary>
public interface IOikopleuridae
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
