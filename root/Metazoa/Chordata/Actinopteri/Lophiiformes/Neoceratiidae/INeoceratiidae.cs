namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Neoceratiidae;

/// <summary>
/// Interface defining characteristics of Neoceratiidae (family).
/// </summary>
public interface INeoceratiidae
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
