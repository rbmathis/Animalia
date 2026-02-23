namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Euclichthyidae;

/// <summary>
/// Interface defining characteristics of Euclichthyidae (family).
/// </summary>
public interface IEuclichthyidae
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
