namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae;

/// <summary>
/// Interface defining characteristics of Diceratiidae (family).
/// </summary>
public interface IDiceratiidae
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
