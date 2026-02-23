namespace AnimalKingdom.root.Metazoa.Chordata.Coelacanthiformes.Coelacanthidae;

/// <summary>
/// Interface defining characteristics of Coelacanthidae (family).
/// </summary>
public interface ICoelacanthidae
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
