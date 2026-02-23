namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae;

/// <summary>
/// Interface defining characteristics of Perophoridae (family).
/// </summary>
public interface IPerophoridae
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
