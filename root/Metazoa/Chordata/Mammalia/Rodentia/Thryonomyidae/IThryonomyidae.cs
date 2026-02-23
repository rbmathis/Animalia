namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae;

/// <summary>
/// Interface defining characteristics of Thryonomyidae (family).
/// </summary>
public interface IThryonomyidae
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
