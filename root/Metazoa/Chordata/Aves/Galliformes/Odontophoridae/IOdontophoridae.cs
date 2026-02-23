namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

/// <summary>
/// Interface defining characteristics of Odontophoridae (family).
/// </summary>
public interface IOdontophoridae
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
