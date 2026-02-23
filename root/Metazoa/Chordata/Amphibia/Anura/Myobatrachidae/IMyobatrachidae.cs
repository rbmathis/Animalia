namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

/// <summary>
/// Interface defining characteristics of Myobatrachidae (family).
/// </summary>
public interface IMyobatrachidae
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
