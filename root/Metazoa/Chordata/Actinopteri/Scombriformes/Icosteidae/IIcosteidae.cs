namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Icosteidae;

/// <summary>
/// Interface defining characteristics of Icosteidae (family).
/// </summary>
public interface IIcosteidae
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
