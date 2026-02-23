namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Leptochilichthyidae;

/// <summary>
/// Interface defining characteristics of Leptochilichthyidae (family).
/// </summary>
public interface ILeptochilichthyidae
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
