namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae;

/// <summary>
/// Interface defining characteristics of Thylacinidae (family).
/// </summary>
public interface IThylacinidae
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
