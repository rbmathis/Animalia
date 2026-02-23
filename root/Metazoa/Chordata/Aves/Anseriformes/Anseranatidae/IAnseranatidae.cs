namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anseranatidae;

/// <summary>
/// Interface defining characteristics of Anseranatidae (family).
/// </summary>
public interface IAnseranatidae
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
