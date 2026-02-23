namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae;

/// <summary>
/// Interface defining characteristics of Ceratiidae (family).
/// </summary>
public interface ICeratiidae
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
