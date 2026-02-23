namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

/// <summary>
/// Interface defining characteristics of Cirrhitidae (family).
/// </summary>
public interface ICirrhitidae
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
