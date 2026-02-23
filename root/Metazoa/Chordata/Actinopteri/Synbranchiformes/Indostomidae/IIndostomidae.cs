namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae;

/// <summary>
/// Interface defining characteristics of Indostomidae (family).
/// </summary>
public interface IIndostomidae
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
