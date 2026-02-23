namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Kryptoglanidae;

/// <summary>
/// Interface defining characteristics of Kryptoglanidae (family).
/// </summary>
public interface IKryptoglanidae
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
