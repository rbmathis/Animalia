namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae;

/// <summary>
/// Interface defining characteristics of Veliferidae (family).
/// </summary>
public interface IVeliferidae
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
