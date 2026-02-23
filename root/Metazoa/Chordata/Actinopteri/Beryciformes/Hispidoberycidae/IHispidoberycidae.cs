namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Hispidoberycidae;

/// <summary>
/// Interface defining characteristics of Hispidoberycidae (family).
/// </summary>
public interface IHispidoberycidae
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
