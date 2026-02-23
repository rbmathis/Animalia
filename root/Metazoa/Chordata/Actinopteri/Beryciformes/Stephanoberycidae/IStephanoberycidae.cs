namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae;

/// <summary>
/// Interface defining characteristics of Stephanoberycidae (family).
/// </summary>
public interface IStephanoberycidae
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
