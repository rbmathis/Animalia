namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

/// <summary>
/// Interface defining characteristics of Plotosidae (family).
/// </summary>
public interface IPlotosidae
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
