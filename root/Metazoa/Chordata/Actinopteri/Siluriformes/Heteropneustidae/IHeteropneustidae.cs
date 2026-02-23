namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heteropneustidae;

/// <summary>
/// Interface defining characteristics of Heteropneustidae (family).
/// </summary>
public interface IHeteropneustidae
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
