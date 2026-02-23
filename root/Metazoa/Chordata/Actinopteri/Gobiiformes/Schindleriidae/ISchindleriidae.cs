namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae;

/// <summary>
/// Interface defining characteristics of Schindleriidae (family).
/// </summary>
public interface ISchindleriidae
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
