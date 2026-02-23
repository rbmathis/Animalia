namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoryctemorphia.Notoryctidae;

/// <summary>
/// Interface defining characteristics of Notoryctidae (family).
/// </summary>
public interface INotoryctidae
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
